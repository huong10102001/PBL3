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
        public delegate void UserId(string UserId);
        public Ten ten;
        public UserId userId;

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
                MessageBox.Show("Please enter your full account and password! / Hãy nhập đầy đủ tài khoản và mật khẩu!");
            }
            else { 
                AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                if (Login(userName, passWord))
                {
                    if (loginAccount.Type == 0)
                    {
                        BookingForm bkf = new BookingForm(txtUserName.Text);
                        this.data += new passData(bkf.setvalue);
                        data(a, b, c);

                        this.ten += new Ten(bkf.setname);
                        this.userId += new UserId(bkf.setUserID);
                        ten(AccountDAO.Instance.getName(userName,passWord));

                        this.user += new UserName(bkf.setUserName);
                        user(userName);

                        userId(AccountDAO.Instance.GetAccountByUserName(userName).UserName);
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
                    MessageBox.Show("Wrong username or password! / Sai tên tài khoản hoặc mật khẩu!");
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
            this.Show();
        }
    }
}
