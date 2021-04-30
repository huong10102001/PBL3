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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        string username, ten;
        public void setusername(String _username)
        {
            username = _username;
        }
        
        public void setname ( String _ten)
        {
            ten = _ten;
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            float totalprice = Convert.ToSingle(textBox4.Text);
   
            string text = "Bạn có chắc chắn thanh toán \n Tổng tiền: " + totalprice;
            DialogResult dialogResult = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BILL_KHDAO.Instance.Checkout(username, totalprice);
                MessageBox.Show("Thanh toán thành công");
            }   
            else if (dialogResult == DialogResult.No)
            {
            }    
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            BookingForm f = new BookingForm();
            this.Hide();
            f.ShowDialog();
        }
    }
}
