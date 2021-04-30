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

        public BILL_KHDTO Checkout(string userName)
        {
            string query = string.Format("USP_InsertBill N'{0}'", userName);
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new BILL_KHDTO(item);
            }
            return null;
        }
        public BILL_KHDTO GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = string.Format("exec USP_GetListBillByDate @checkIn , @checkOut", checkIn, checkOut);
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new BILL_KHDTO(item);
            }
            return null;
        }

    }
}
