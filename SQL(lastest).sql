use AirlineManagementSystem

create table User_Account
(
	user_id int primary key,
	user_type nvarchar(20) not null,
	user_username nvarchar(30) not null,
	user_password nvarchar(30) not null,
)

create table Passenger 
(
	pas_id int primary key,
	pas_name nvarchar(30) not null,
	pas_mobile nvarchar(30) not null,
	pas_email nvarchar(30) not null,
	pas_address nvarchar(50) not null,
	--user_username nvarchar(30) not null,
	--user_password nvarchar(30) not null,
	user_id int not null,

	FOREIGN KEY (user_id) REFERENCES dbo.User_Account
)

create table Employee
(
	employee_id int primary key,
	employee_name nvarchar(30) not null,
	employee_email nvarchar(30) not null,
	employee_mobile nvarchar(30) not null,
	employee_password nvarchar(30) not null,
	employee_username nvarchar (30) not null,
	employee_address nvarchar(50) not null,
	user_id int   not null,

	FOREIGN KEY (user_id) REFERENCES dbo.User_Account
)

create table AirlinesEnquiry
(
	AE_id int primary key,
	AE_type nvarchar(30) not null,
	AE_title nvarchar(30) not null, -- in order to Search
	AE_description nvarchar(1000),
	AE_date date not null
)

create table TicketBooking
(
	TB_id int primary key,
	TB_description nvarchar(1000),
	TB_date date not null
)

create table AirlinesBooking
(
	AB_id int primary key,
	AB_TB_id int not null,
	AB_description nvarchar(1000),
	AB_type nvarchar(30) not null,
	AB_date date not null,
	pas_id int not null,

	FOREIGN KEY (pas_id) REFERENCES dbo.Passenger, -- foreign key from Passenger
	FOREIGN KEY (AB_TB_id) REFERENCES dbo.TicketBooking -- foreign key from Ticketbooking
)
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.User_Account WHERE user_username = @userName
END
GO


CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.User_Account WHERE user_username = @userName AND user_password = @passWord
END
GO

USP_Login nhi, 1
