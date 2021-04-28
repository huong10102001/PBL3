using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = string.Format("USP_Login N'{0}', N'{1}'", userName, passWord);
            DataTable result = DataProvider.Instance.GetRecord(query);
            return result.Rows.Count > 0;

        }

        public AccountDTO GetAccountByUserName(string userName)
        {
            string query = string.Format("SELECT * FROM USERS WHERE us_username = '" + userName + "'");
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public AccountDTO Signup(string userName, string passWord,  string name, string email, string phone, string address)
        { 
            string query = string.Format("SIGNUP N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}' ", userName, passWord,  name, email, phone, address);
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }
        public void UpdateAccount(string name, string email, string phone, string address, string username)
        {
            string query = string.Format("UPDATE USERS SET us_name = N'{0}', us_email = N'{1}', us_phone = N'{2}', us_address = N'{3}' WHERE us_username = N'{4}'",name, email, phone, address, username);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void ChangePassword(string password, string username)
        {
            string query = string.Format("UPDATE USERS SET us_password = N'{0}' WHERE us_username = N'{1}'", password, username);
            DataProvider.Instance.ExecuteDB(query);
        }

    }
}
