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
    public partial class ViewFlightForm : Form
    {
        private string FLIGHT_ID;
        private string USERNAME;
        private string BUTTON_MODE;
        private int TICKET_ID;
        public ViewFlightForm(String fl_id , String username)
        {
            FLIGHT_ID = fl_id;
            USERNAME = username;
            InitializeComponent();
            ListViewLoad();
            //LoadCBB();
        }
        public void ListViewLoad()
        {
            listView1.Items.Clear();
            List<PriceDTO> PriceList = PriceDAO.Instance.PriceList;
            int first = PriceList[0].id;
            int delta = PriceList[1].id;
            int main = PriceList[2].id;
            int econo = PriceList[3].id;
            foreach (TicketDTO item in TicketDAO.Instance.GetListTicketPerFlight(FLIGHT_ID))
            {
                ListViewItem lvsItem = new ListViewItem(item.ticket_id.ToString());
                lvsItem.SubItems.Add(item.us_username.ToString());
                lvsItem.SubItems.Add(item.ticket_name.ToString());
                switch (item.ticket_gender) 
                {
                    case true:
                        lvsItem.SubItems.Add("Male");
                        break;
                    case false:
                        lvsItem.SubItems.Add("Female");
                        break;
                }
                lvsItem.SubItems.Add(item.ticket_mobile.ToString());
                lvsItem.SubItems.Add(item.ticket_address.ToString());
                if(item.price_id == first)
                {
                    string txt = "F" + item.seat_number;
                    lvsItem.SubItems.Add(txt);
                }
                else if (item.price_id == delta)
                {
                    string txt = "D" + item.seat_number;
                    lvsItem.SubItems.Add(txt);
                }
                else if (item.price_id == main)
                {
                    string txt = "M" + item.seat_number;
                    lvsItem.SubItems.Add(txt);
                }
                else if(item.price_id == econo)
                {
                    string txt = "B" + item.seat_number;
                    lvsItem.SubItems.Add(txt);
                }

                listView1.Items.Add(lvsItem);
            }
            listView1.Columns[0].Width = 0;
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e) //add
        {
            SeatsBooking f = new SeatsBooking(FLIGHT_ID, USERNAME, "ADMIN_ADD");
            f.ShowDialog();
            ListViewLoad();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e) //edit
        {
            if(listView1.FocusedItem != null)
            {
                int ticket_id = Convert.ToInt32(listView1.FocusedItem.SubItems[0].Text);
                SeatsBooking f = new SeatsBooking(FLIGHT_ID, USERNAME, "ADMIN_EDIT", ticket_id);
                f.ShowDialog();
                ListViewLoad();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hành khách");
            }
            
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e) //delete
        {
            if (listView1.FocusedItem != null)
            {
                int ticket_id = Convert.ToInt32(listView1.FocusedItem.SubItems[0].Text);
                string ticket_name = listView1.FocusedItem.SubItems[2].Text;
                string text = "Xác nhận xóa hành khách "+ ticket_name +" khỏi chuyến bay?";
                DialogResult dialogResult = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketDAO.Instance.DeleteTicketFromDataBase(ticket_id);
                    ListViewLoad();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hành khách");
            }
        }


        private void ShowFlightForm_Load(object sender, EventArgs e)
        {
            lbText.Text = FLIGHT_ID + "'s Passengers";
        }
    }
}
