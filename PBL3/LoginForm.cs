﻿using PBL3.DAO;
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
        
        public LoginForm()
        {
            InitializeComponent();
        }
      

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
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
            AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
            if (Login(userName, passWord))
            {
                if (loginAccount.Type == 0)
                {
                    BookingForm bkf = new BookingForm();
                    this.Hide();
                    bkf.ShowDialog();
                }
                else if (loginAccount.Type == 1)
                {
                    FlightManagement fmf = new FlightManagement();
                    this.Hide();
                    fmf.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            SignUpForm f = new SignUpForm();
            f.ShowDialog();
        }
    }
}
