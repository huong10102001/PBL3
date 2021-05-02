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
        TicketDTO tickets = new TicketDTO();
        public void GetInfo(TicketDTO info_ticket)
        {
            tickets = info_ticket;
        }
        public PaymentForm(List<TicketDTO> ticket, string username)
        {
            InitializeComponent();
            LoadInformation(ticket);
            setusername(username);
        }
        string username, ten;
        public void setusername(String _username)
        {
            username = _username;
            AccountDTO a = AccountDAO.Instance.GetAccountByUserName(username);
            ten = a.Name;
            label9.Text = ten;
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
        public void LoadInformation(List<TicketDTO> ticket)
        {
            FlightDTO flight = new FlightDTO();
            float price = 0;
            foreach (TicketDTO t in ticket)
            {
                flight = FlightDAO.Instance.GetFlightByID(t.fl_id);
                price += PriceDAO.Instance.GetPriceById(t.price_id);
            }
            price *= AirlineDAO.Instance.GetAirlineIndexbyID(flight.airline_id);

            label10.Text = PlaceDAO.Instance.GetSource(flight.fl_source);
            label11.Text = PlaceDAO.Instance.GetDes(flight.fl_destination);
            label12.Text = flight.takeoff.ToString();
            label13.Text = flight.landing.ToString();
            textBox4.Text = price.ToString();

            if (flight.triptype)
            {
                FlightDTO flight2 = FlightDAO.Instance.GetFlightByID(flight.id_roundtrip);
                label14.Text = PlaceDAO.Instance.GetDes(flight2.fl_destination);
                label15.Text = flight2.landing.ToString();
                label16.Text = flight2.takeoff.ToString();
            }
            else
            {
                textBox3.Visible = false;
                pictureBox2.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
            }
                
        }
    }
}
