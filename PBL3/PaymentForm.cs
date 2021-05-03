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
        List<TicketDTO> listTicket2;
        TicketDTO tickets = new TicketDTO();
        public void GetInfo(TicketDTO info_ticket)
        {
            tickets = info_ticket;
        }
        public PaymentForm(List<TicketDTO> ticket1, string username , List<TicketDTO> ticket2)
        {
            listTicket = ticket1;
            listTicket2 = ticket2;
            InitializeComponent();
            LoadInformation(ticket1, ticket2);
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
                    if(listTicket2.Count > 0)
                    {
                        foreach (TicketDTO i in listTicket2)
                        {
                            TicketDAO.Instance.AddTicketToDataBase(i.fl_id, i.us_username, i.ticket_name, i.ticket_gender, i.ticket_mobile, i.ticket_address, i.seat_number, i.price_id);
                        }
                    }
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

       

        private void textBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == textBox5)
            {
                textBox5.Text = "";
            }
            if (sender == textBox6)
            {
                textBox6.Text = "";
            }
            if (sender == textBox7)
            {
                textBox7.Text = "";
            }
        }

        public void LoadInformation(List<TicketDTO> ticket1, List<TicketDTO> ticket2)
        {
            FlightDTO flight1 = new FlightDTO();
            FlightDTO flight2 = new FlightDTO(); 
            float price1 = 0, price2 = 0, price = 0;
            foreach (TicketDTO t in ticket1)
            {
                flight1 = FlightDAO.Instance.GetFlightByID(t.fl_id);
                price1 += PriceDAO.Instance.GetPriceById(t.price_id);
            }
            if(ticket2.Count != 0)
            {
                foreach (TicketDTO t1 in ticket2)
                {
                    flight2 = FlightDAO.Instance.GetFlightByID(t1.fl_id);
                    price2 += PriceDAO.Instance.GetPriceById(t1.price_id);
                }
                price2 *= AirlineDAO.Instance.GetAirlineIndexbyID(flight2.airline_id);
            }         
            
            price1 *= AirlineDAO.Instance.GetAirlineIndexbyID(flight1.airline_id);
            price = price1 + price2;

            label10.Text = PlaceDAO.Instance.GetSource(flight1.fl_source);
            label11.Text = PlaceDAO.Instance.GetDes(flight1.fl_destination);
            label12.Text = flight1.takeoff.ToString();
            label13.Text = flight1.landing.ToString();
            label17.Text = price.ToString();

            if (flight1.triptype)
            {
               // FlightDTO flight2 = FlightDAO.Instance.GetFlightByID(flight.id_roundtrip);
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
