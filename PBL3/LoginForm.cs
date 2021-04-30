using PBL3.DAO;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class LoginForm : Form
    {
        public delegate void Ten(String name);
        public Ten ten;

        public delegate void UserName(String username);
        public UserName user;

        public delegate void passData(String from, String to, String date);
        public passData data;
        string a, b, c;
        public void setvalue(String from, String to, String date)
        {
            a = from;
            b = to;
            c = date;
        }
        
        public LoginForm()
        {
            InitializeComponent();
        }
      
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            if (userName == "" && passWord == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ tài khoản và mật khẩu");
            }
            else { 
                AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                if (Login(userName, passWord))
                {
                    if (loginAccount.Type == 0)
                    {
                        BookingForm bkf = new BookingForm();
                        this.data += new passData(bkf.setvalue);
                        data(a, b, c);

                        this.ten += new Ten(bkf.setname);
                        ten(AccountDAO.Instance.getName(userName,passWord));

                        this.user += new UserName(bkf.setUserName);
                        user(userName);

                        this.Hide();
                        bkf.ShowDialog();
                    }
                    else if (loginAccount.Type == 1)
                    {
                        FlightManagement fmf = new FlightManagement(txtUserName.Text);
                        this.Hide();
                        fmf.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                }
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            OverviewForm f = new OverviewForm();
            this.Hide();
            f.ShowDialog();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
           
            this.Hide();
            f.ShowDialog();
        }
    }
}
