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
            LoadCBB();
        }
        public void ListViewLoad()
        {
            listView1.Items.Clear();
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
                listView1.Items.Add(lvsItem);
            }
            listView1.Columns[0].Width = 0;
        }
        public void LoadCBB()
        {
            cbbGender.Items.Add(new CBBItem(1, "Male"));
            cbbGender.Items.Add(new CBBItem(0, "Female"));
            cbbGender.DisplayMember = "Text";
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e) //add
        {
            panel.Visible = true;
            lblMode.Text = "Add A Ticket";
            btnAddEdit.Text = "ADD";

            txbName.Text = "";
            txbAddress.Text = "";
            txbPhone.Text = "";
            cbbGender.SelectedItem = null;

            BUTTON_MODE = "add";
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e) //edit
        {
            if(listView1.FocusedItem != null)
            {
                panel.Visible = true;
                btnAddEdit.Text = "EDIT";
                int ticket_id = Convert.ToInt32(listView1.FocusedItem.SubItems[0].Text);
                TICKET_ID = ticket_id;
                TicketDTO tk = TicketDAO.Instance.GetTicketByID(ticket_id);
                var names = tk.ticket_name.Split(' ');
                lblMode.Text = "Edit "+names[names.Length - 1]+"'s Ticket?";

                txbName.Text = tk.ticket_name;
                txbAddress.Text = tk.ticket_address;
                txbPhone.Text = tk.ticket_mobile;
                cbbGender.SelectedIndex = (tk.ticket_gender) ? 0 : 1;

                BUTTON_MODE = "edit";
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
            panel.Visible = false;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if(BUTTON_MODE == "add")
            {
                AddTicket();
            }
            else
            {
                EditTicket();
            }
        }
        public void AddTicket()
        {
            if(txbName.Text == "" || txbAddress.Text == "" || txbPhone.Text == "" || cbbGender.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập dữ liệu hệ thống", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketDAO.Instance.AddTicketToDataBase(FLIGHT_ID, USERNAME, txbName.Text, Convert.ToBoolean(((CBBItem)cbbGender.SelectedItem).Value), txbPhone.Text, txbAddress.Text);
                    ListViewLoad();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
                
            }
        }
        public void EditTicket()
        {
            if (txbName.Text == "" || txbAddress.Text == "" || txbPhone.Text == "" || cbbGender.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập dữ liệu hệ thống", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketDAO.Instance.EditTicketToDataBase(TICKET_ID, txbName.Text, Convert.ToBoolean(((CBBItem)cbbGender.SelectedItem).Value), txbPhone.Text, txbAddress.Text);
                    ListViewLoad();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }   
            }
        }
    }
}
