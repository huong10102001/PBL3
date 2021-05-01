﻿using PBL3.DTO;
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
    }
}
