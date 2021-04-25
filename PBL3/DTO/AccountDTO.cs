using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class AccountDTO
    {
        private static AccountDTO instance;

        public static AccountDTO Instance
        {
            get { if (instance == null) instance = new AccountDTO(); return instance; }
            private set { instance = value; }
        }
        private AccountDTO() { }

        private string userName;
        public string UserName { get => userName; set => userName = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private int type;
        public int Type { get => type; set => type = value; }


        private string name;
        public string Name { get => name; set => name = value; }
        private string email;
        public string Email { get => email; set => email = value; }
        private string phone;
        public string Phone { get => phone; set => phone = value; }
        private string address;
        public string Address { get => address; set => address = value; }
        public AccountDTO(int id, string userName, string passWord, int type, string name, string email, string phone, string address)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.Type = type;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["us_username"].ToString();
            this.PassWord = row["us_password"].ToString();
            this.Type = (int)row["us_type"];
            this.Name = row["us_name"].ToString();
            this.Email = row["us_email"].ToString();
            this.Phone = row["us_phone"].ToString();
            this.Address = row["us_address"].ToString();

        }
    }
}
