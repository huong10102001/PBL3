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
    public partial class InfoForm : Form
    {
        private string staff_id;
        public InfoForm()
        {
            InitializeComponent();
        }

        public void FormInit(string STAFF_ID)
        {
            this.staff_id = STAFF_ID;
            AccountDTO acc = AccountDAO.Instance.GetAccountByUserName(STAFF_ID);
            txbID.Text = acc.UserName;
            txbName.Text = acc.Name;
            txbAddress.Text = acc.Address;
            txbEmail.Text = acc.Email;
            txbPhone.Text = acc.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.UpdateAccount(txbName.Text, txbEmail.Text, txbPhone.Text, txbAddress.Text, txbID.Text);
            MessageBox.Show("Đã cập nhập tài khoản!");
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            AccountDTO acc = AccountDAO.Instance.GetAccountByUserName(staff_id);

            if(txbNewpass.Text == "" || txbCRpass.Text == "" || txbCFpass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ!");
            }
            else
            {
                if (txbCRpass.Text == acc.PassWord)
                {
                    if (txbCFpass.Text == txbNewpass.Text)
                    {
                        AccountDAO.Instance.ChangePassword(txbNewpass.Text, acc.UserName);
                        MessageBox.Show("Đã cập nhập mật khẩu!");

                        txbCFpass.Text = "";
                        txbCRpass.Text = "";
                        txbNewpass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu không khớp!");
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hiện tại!");
                }
            }  
        }
    }
}
