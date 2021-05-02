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
        public delegate void RemoveListCallback();
        public RemoveListCallback remove;

        //SeatsBooking SEAT;
        List<TicketDTO> listTicket;
        TicketDTO tickets = new TicketDTO();
        public void GetInfo(TicketDTO info_ticket)
        {
            tickets = info_ticket;
        }
        public PaymentForm(List<TicketDTO> ticket, string username)
        {
            listTicket = ticket;
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
            float totalprice = Convert.ToSingle(label17.Text);
            if(textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string text = "Bạn có chắc chắn thanh toán \n Tổng tiền: " + totalprice;
                DialogResult dialogResult = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BILL_KHDAO.Instance.Checkout(username, totalprice);
                    foreach (TicketDTO i in listTicket)
                    {
                        TicketDAO.Instance.AddTicketToDataBase(i.fl_id, i.us_username, i.ticket_name, i.ticket_gender, i.ticket_mobile, i.ticket_address, i.seat_number, i.price_id);
                    }
                    MessageBox.Show("Thanh toán thành công");

                    remove();

                    Dispose();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }                   
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label18.Visible = false;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label19.Visible = false;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label20.Visible = false;

        }

        public void LoadInformation(List<TicketDTO> ticket)
        {
            FlightDTO flight = new FlightDTO();
            //FlightDTO flight1 = new FlightDTO(); 
            float price = 0;
            foreach (TicketDTO t in ticket)
            {
                flight = FlightDAO.Instance.GetFlightByID(t.fl_id);
                price += PriceDAO.Instance.GetPriceById(t.price_id);
            }
            //flight1 = FlightDAO.Instance.GetFlightByID(flight.id_roundtrip);
            //foreach()
            price *= AirlineDAO.Instance.GetAirlineIndexbyID(flight.airline_id);

            label10.Text = PlaceDAO.Instance.GetSource(flight.fl_source);
            label11.Text = PlaceDAO.Instance.GetDes(flight.fl_destination);
            label12.Text = flight.takeoff.ToString();
            label13.Text = flight.landing.ToString();
            label17.Text = price.ToString();

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
