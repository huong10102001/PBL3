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
    public partial class FlightTicketForm : Form
    {
        string USERNAME = null;
        public FlightTicketForm(string user)
        {
            USERNAME = user;
            InitializeComponent();
            LoadListView1(USERNAME);
            LoadListView2(USERNAME);
        }
        //public void setUserId(string CUSTOMER_ID)
        //{
        //    this.user = CUSTOMER_ID;
        //    Load();

        //}
        //public void LoadForm(string user)
        //{
        //    dataGridView1.DataSource = TicketDAO.Instance.GetTicketByUserName(user, 0);
        //    dataGridView1.Columns["ticket_id"].Visible = false;

        //    dataGridView2.DataSource = TicketDAO.Instance.GetTicketByUserName(user, 1);
        //    dataGridView2.Columns["ticket_id"].Visible = false;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadListView1(string user)
        {
            listView1.Items.Clear();
            foreach (TicketDTO i in TicketDAO.Instance.GetTicketByUserName(user, 0))
            {
                ListViewItem lvsItem = new ListViewItem(AirlineDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id));
                lvsItem.SubItems.Add(SourceDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).fl_source));
                lvsItem.SubItems.Add(DestinationDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).fl_destination));
                lvsItem.SubItems.Add(i.ticket_name);

                List<PriceDTO> PriceList = PriceDAO.Instance.PriceList;
                int first = PriceList[3].id;
                int delta = PriceList[2].id;
                int main = PriceList[1].id;
                int econo = PriceList[0].id;

                if (i.price_id == first)
                {
                    string txt = "F" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[0].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == delta)
                {
                    string txt = "D" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[1].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == main)
                {
                    string txt = "M" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[2].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == econo)
                {
                    string txt = "B" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[3].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }

                listView1.Items.Add(lvsItem);
            }

        }
        public void LoadListView2(string user)
        {
            listView2.Items.Clear();
            foreach (TicketDTO i in TicketDAO.Instance.GetTicketByUserName(user, 1))
            {
                ListViewItem lvsItem = new ListViewItem(AirlineDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id));
                lvsItem.SubItems.Add(SourceDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).fl_source));
                lvsItem.SubItems.Add(DestinationDAO.Instance.GetNameByID(FlightDAO.Instance.GetFlightByID(i.fl_id).fl_destination));
                lvsItem.SubItems.Add(i.ticket_name);

                List<PriceDTO> PriceList = PriceDAO.Instance.PriceList;
                int first = PriceList[3].id;
                int delta = PriceList[2].id;
                int main = PriceList[1].id;
                int econo = PriceList[0].id;

                if (i.price_id == first)
                {
                    string txt = "F" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[0].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == delta)
                {
                    string txt = "D" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[1].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == main)
                {
                    string txt = "M" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[2].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == econo)
                {
                    string txt = "B" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    string price = "" + PriceDAO.Instance.PriceList[3].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    lvsItem.SubItems.Add(price);
                }

                listView2.Items.Add(lvsItem);
            }

        }
    }
}
