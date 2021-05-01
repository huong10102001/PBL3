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
            double totalPrice = Convert.ToDouble(textBox4.Text.Split(',')[0]);

            string text = "Bạn có chắc chắn thanh toán \n Tổng tiền: " + totalPrice;
            DialogResult dialogResult = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BILL_KHDAO.Instance.Checkout(username);
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
        public void LoadInformation()
        {
            List<PriceDTO> priceList = PriceDAO.Instance.PriceList;

            List<FlightDTO> list = FlightDTO.Instance.GetAllFight();

            Information[] information  = new Information[list.Count];

            foreach (FlightDTO i in list)
            {
                int s = 0;
                for (int j = 0; j < information.Length; j++)
                {

                    information[j] = new ListFight();
                    information[j].price = i;
                    information[j].time = i.takeoff.ToString();
                    information[j].places = i.fl_source.ToString();
                    information[j].SetLabel();

                }
                flowLayoutPanel1.Controls.Add(information[s]);
                s++;
            }
        }
    }
}
