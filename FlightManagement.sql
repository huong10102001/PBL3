
select airline_name, fl_takeoftime, fl_price, fl_triptype, fl_description, PLACE.place_name, PLACE.place_name_to from FLIGHT, AIRLINE, PLACE where AIRLINE.airline_id = FLIGHT.airline_id and fl_triptype = 'circle trip' 

use FlightManagement

create table USERS
(
	us_username nvarchar(20) primary key not null,
	us_password nvarchar(20) not null,
	us_type int default 0 not null,
	us_name nvarchar(20),
	us_email nvarchar(20),
	us_phone nvarchar(20),
	us_address nvarchar(50),
	foreign key (us_username) references dbo.USERS(us_username)

)
create table PRICE 
(
	id int primary key identity not null,
	name nvarchar not null,
	price float not null
)
create table AIRLINE
(
	airline_id int primary key identity not null,
	airline_name nvarchar(20) not null,
	airline_index float not null
)
create table SOURCE
(
	src_id int primary key identity not null,
	src_name nvarchar(20) not null,
)
create table DESTINATION
(
	des_id int primary key identity not null,
	des_name nvarchar(20) not null,
)
create table FLIGHT
(
	fl_id nvarchar(20) primary key not null,
	airline_id int not null,
	fl_source int not null,
	fl_destination int not null,
	fl_takeoftime datetime not null,
	fl_landingtime datetime not null,
	fl_triptype bit not null,
	fl_description nvarchar(50) not null,
	fl_status int default 0 not null,
	fl_capacity int not null,

	foreign key (airline_id) references dbo.AIRLINE(airline_id),
	foreign key (fl_source) references dbo.SOURCE(src_id),
	foreign key (fl_destination) references dbo.DESTINATION(des_id)
)
create table TICKET
(
	ticket_id int primary key identity not null,
	fl_id nvarchar(20) not null,
	us_username nvarchar(20) not null,
	ticket_name nvarchar(20) not null,
	ticket_gender bit not null,
	ticket_mobile nvarchar(20) not null,
	ticket_address nvarchar(20) not null,

	foreign key (fl_id) references dbo.FLIGHT(fl_id),
	foreign key (us_username) references dbo.USERS(us_username)
)
GO

CREATE TABLE BILL_KH
(
	bill_id int primary key identity not null,
	DateOne date ,
	DateTwo date ,
	us_username nvarchar (20) not null

	foreign key (us_username) references dbo.USERS(us_username)
)

alter table dbo.BILL_KH add totalprice float

CREATE TABLE FEEDBACK
(
	feedback_id int primary key identity not null,
	DateFB date ,
	us_username nvarchar (20) not null

	foreign key (us_username) references dbo.USERS(us_username)
)

alter table dbo.FEEDBACK add content nvarchar(1000)

alter table dbo.BILL_KH add totalprice float

CREATE TABLE BILL_FL
(
	bill_id_fl int primary key identity not null,
	DateOne_fl date,
	DateTwo_fl date,
	fl_id nvarchar(20) 

	foreign key (fl_id) references dbo.FLIGHT(fl_id)
)

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.USERS WHERE us_username = @userName
END
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.USERS WHERE us_username = @userName AND us_password = @passWord
END
GO

CREATE PROC SIGNUP
@userName nvarchar (20),
@passWord nvarchar (20),
@name nvarchar (20),
@email nvarchar (20),
@phone nvarchar (20),
@address nvarchar (20)
AS
	INSERT INTO USERS 
	(
		us_username ,
		us_password ,
		us_name ,
		us_email ,
		us_phone ,
		us_address 
	)
	VALUES
	(
		@userName ,
		@passWord ,
		@name ,
		@email,
		@phone ,
		@address 
	)


CREATE PROC USP_Insert_Feedback
@us_username nvarchar(20),
@content nvarchar (1000),
AS
BEGIN
	INSERT dbo.FEEDBACK 
	        ( DateFB ,
	          us_username,
	          content
	        )
	VALUES  ( GETDATE() , 
	          @us_username , 
	          @content  
	        )
END
GO

CREATE PROC USP_InsertBill
@us_username INT
AS
BEGIN
	INSERT INTO dbo.BILL_KH 
	        ( DateOne ,
	          DateTwo ,
	          us_username
  
	        )
	VALUES  ( GETDATE() , 
	          NULL , 
	          @us_username 
	        )
END
GO

CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT u.us_name AS [Tên khách hàng], b.totalPrice AS [T?ng ti?n], DateOne AS [Ngày vào], DateTwo AS [Ngày ra]
	FROM dbo.BILL_KH AS b,dbo.USERS AS u
	WHERE DateOne >= @checkIn AND DateTwo <= @checkOut 
	AND b.us_username = u.us_username
END
GO

--CREATE TRIGGER UTG_UpdateBillKH
--ON dbo.BILL_KH FOR UPDATE
--AS
--BEGIN
--	DECLARE @idBill INT
	
--	SELECT @idBill = bill_id FROM Inserted	
	
--	DECLARE @us_username INT
	
--	SELECT @us_username = us_username FROM dbo.BILL_KH WHERE bill_id = @idBill
--	END
--
--GO
SELECT us_name, us_email, content, dateFB FROM FEEDBACK INNER JOIN USERS ON FEEDBACK.us_username = USERS.us_username
SELECT us_name as [Customer Name], us_email as [Customer Email], content as [Feedback], dateFB as [Feedback Day] FROM FEEDBACK INNER JOIN USERS ON FEEDBACK.us_username = USERS.us_username WHERE us_name= 'Thu H??ng'




