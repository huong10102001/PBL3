using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class BILL_KHDAO
    {
        private static BILL_KHDAO instance;

        public static BILL_KHDAO Instance
        {
            get { if (instance == null) instance = new BILL_KHDAO(); return instance; }
            private set { instance = value; }
        }

        private BILL_KHDAO() { }

        public BILL_KHDTO Checkout(string userName, double totalprice)
        {
            string query = string.Format("InsertBill N'{0}', N'{1}'", userName, totalprice);
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new BILL_KHDTO(item);
            }
            return null;
        }
        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string intime = checkIn.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string outtime = checkOut.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string query = string.Format("SELECT u.us_name AS [Customer Name], u.us_email AS [Email], u.us_phone AS [Phone], b.totalprice AS [Total Price], b.DateTwo AS [Date] FROM dbo.BILL_KH AS b, dbo.USERS AS u WHERE DateOne >= '{0}' AND DateTwo <= '{1}' AND b.us_username = u.us_username", intime, outtime);
            DataTable data = DataProvider.Instance.GetRecord(query);
            return data;
        }

        public DataTable GetBillListByFlight(DateTime checkIn, DateTime checkOut)
        {
            string intime = checkIn.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string outtime = checkOut.Date.ToString("yyyy-MM-dd HH:mm:ss");
            string query = string.Format("SELECT FLIGHT.fl_id AS 'FLight ID', COUNT(ticket_id) AS 'Number of Sold Tickets', SUM(price * airline_index) AS 'Totalprice', fl_takeoftime as 'Date' FROM FLIGHT INNER JOIN TICKET ON FLIGHT.fl_id = TICKET.fl_id INNER JOIN AIRLINE ON FLIGHT.airline_id = AIRLINE.airline_id INNER JOIN PRICE ON TICKET.price_id = PRICE.id WHERE fl_takeoftime >= '{0}' AND fl_landingtime <= '{1}' GROUP BY FLIGHT.fl_id, fl_takeoftime", intime, outtime);
            DataTable data = DataProvider.Instance.GetRecord(query);
            return data;
        }
    }
}
