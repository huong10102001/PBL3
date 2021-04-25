using PBL3.DAO;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            string passWord2 = txtPassword2.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            if ((userName != "" || passWord != "" || passWord2 != "" || name != "" || email != "" || phone != "" || address != "") 
                && (userName != "Username" || passWord != "Password" || passWord2 != "Password" || name != "Name" || email != "Email" || phone != "Phone" || address != "Address"))
            {

                if (passWord == passWord2)
                {
                    if (checkBox1.Checked == true)
                    {
                        AccountDAO.Instance.Signup(userName, passWord, name, email, phone, address);
                        MessageBox.Show("Đăng kí thành công");
                        LoginForm lm = new LoginForm();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng đồng ý với các điều khoản của dịch vụ");

                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu chưa trùng khớp");
                }
            }
            else MessageBox.Show("Hãy nhập đầy đủ thông tin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUserName_MouseUp(object sender, MouseEventArgs e)
        {
                txtUserName.Text = "";
        }

        private void txtPassword_MouseUp(object sender, MouseEventArgs e)
        {
                txtPassword.Text = "";
        }

        private void txtPassword2_MouseUp(object sender, MouseEventArgs e)
        {
                txtPassword2.Text = "";
        }

        private void txtName_MouseUp(object sender, MouseEventArgs e)
        {
                txtName.Text = "";
        }

        private void txtEmail_MouseUp(object sender, MouseEventArgs e)
        {
                txtEmail.Text = "";
        }

        private void txtPhone_MouseUp(object sender, MouseEventArgs e)
        {
                txtPhone.Text = "";
        }

        private void txtAddress_MouseUp(object sender, MouseEventArgs e)
        {
                txtAddress.Text = "";
        }

       
    }
}
