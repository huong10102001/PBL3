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
    public partial class FlightManagement : Form
    {
        private string USERNAME;

        public delegate void passSTAFFIDCallBack(string USERNAME);
        public passSTAFFIDCallBack passStaffId;
        public FlightManagement() { }
        public FlightManagement(string username)
        {
            USERNAME = username;

            InitializeComponent();

            LoadComboBox();

            ListViewLoad(FlightDAO.Instance.flightList);

            btnProfile.Text = AccountDAO.Instance.GetAccountByUserName(USERNAME).Name;
        }
        public void ListViewLoad(List<FlightDTO> list)
        {
            listView1.Items.Clear();
            foreach (FlightDTO item in list)
            {
                ListViewItem lvsItem = new ListViewItem(item.fl_id.ToString());
                lvsItem.SubItems.Add(AirlineDAO.Instance.GetNameByID(item.airline_id));
                lvsItem.SubItems.Add(SourceDAO.Instance.GetNameByID(item.fl_source));
                lvsItem.SubItems.Add(DestinationDAO.Instance.GetNameByID(item.fl_destination));
                lvsItem.SubItems.Add(item.takeoff.ToString("dd/MM/yyyy"));
                lvsItem.SubItems.Add(item.takeoff.ToString("H:mm"));
                lvsItem.SubItems.Add(item.landing.ToString("H:mm"));

                switch (item.status)
                {
                    case 0:
                        lvsItem.SubItems.Add("Not yet take-off");
                        lvsItem.SubItems[7].BackColor = Color.LightGoldenrodYellow;
                        break;
                    case 1:
                        lvsItem.SubItems.Add("Arrived");
                        lvsItem.SubItems[7].BackColor = Color.LightGreen;
                        break;
                    case 2:
                        lvsItem.SubItems.Add("Cancel");
                        lvsItem.SubItems[7].BackColor = Color.Tomato;
                        break;
                }

                string soluong = TicketDAO.Instance.GetListTicketPerFlight(item.fl_id).Count + "/60";
                lvsItem.SubItems.Add(soluong);

                switch (Convert.ToInt32(item.triptype))
                {
                    case 0:
                        lvsItem.SubItems.Add("One-Way");
                        break;
                    case 1:
                        lvsItem.SubItems.Add("Round-Trip");
                        break;
                }

                foreach (PriceDTO i in PriceDAO.Instance.PriceList)
                {
                    string result = "" + i.price * AirlineDAO.Instance.GetAirlineIndexbyID(item.airline_id) +"$";
                    lvsItem.SubItems.Add(result);
                }
                lvsItem.UseItemStyleForSubItems = false;
                lvsItem.SubItems[0].ForeColor = Color.MediumVioletRed;
                lvsItem.SubItems[1].ForeColor = Color.DarkBlue;
                listView1.Items.Add(lvsItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        public void LoadComboBox()
        {
            foreach (AirlineDTO i in AirlineDAO.Instance.AirlineList)
            {
                cbbAirline.Items.Add(new CBBItem(i.airline_id, i.airline_name));
            }

            foreach (SourceDTO i in SourceDAO.Instance.SourceList)
            {
                cbbDeparture.Items.Add(new CBBItem(i.src_id, i.src_name));
            }
            foreach (DestinationDTO i in DestinationDAO.Instance.DestinationList)
            {
                cbbDestination.Items.Add(new CBBItem(i.des_id, i.des_name));
            }
        }
        private void BtnAdd(object o, EventArgs e) //add
        {
            UpdateForm f = new UpdateForm();

            f.reload += new UpdateForm.ReloadCallBack(ListViewLoad);

            f.ShowDialog();
        }
        private void BtnEdit(object o, EventArgs e) //edit
        {
            if (listView1.FocusedItem != null)
            {
                string fl_id = listView1.FocusedItem.SubItems[0].Text;

                UpdateForm f = new UpdateForm(fl_id);

                f.reload += new UpdateForm.ReloadCallBack(ListViewLoad);

                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay!");
            }
        }
        private void BtnDelete(object o, EventArgs e) //delete
        {
            if (listView1.FocusedItem != null)
            {
                string fl_id = listView1.FocusedItem.SubItems[0].Text;
                string text = "Vui lòng xác nhận xóa chuyến bay " + fl_id+"!";

                DialogResult dialogResult = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    FlightDAO.Instance.DeleteFlightFromDatabase(fl_id);

                    ListViewLoad(FlightDAO.Instance.flightList);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay!");
            }
        }
        private void BtnView(object o, EventArgs e) // view
        {
            if (listView1.FocusedItem != null)
            {
                string fl_id = listView1.FocusedItem.SubItems[0].Text;
                ViewFlightForm f = new ViewFlightForm(fl_id , USERNAME);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay!");
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            this.passStaffId += new passSTAFFIDCallBack(form.FormInit);
            passStaffId(USERNAME);
            form.ShowDialog();
        }
        private void Search(object o, EventArgs e) // search
        {
            List<FlightDTO> list = new List<FlightDTO>();
            foreach(FlightDTO i in FlightDAO.Instance.flightList)
            {
                list.Add(i);
            }

            if (ckbxID.Checked)
            {
                if (txbID.Text != "")
                {
                    list = FlightDAO.Instance.GetListBySearchID(list, txbID.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                    return;
                }

            }
            if (ckbxAirline.Checked)
            {
                if (cbbAirline.SelectedItem != null)
                {
                    CBBItem item = (CBBItem)cbbAirline.SelectedItem;
                    list = FlightDAO.Instance.GetListBySearchAirline(list, item.Value);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                    return;
                }
            }
            if (ckbxDepart.Checked)
            {
                if (cbbDeparture.SelectedItem != null)
                {
                    CBBItem item = (CBBItem)cbbDeparture.SelectedItem;
                    list = FlightDAO.Instance.GetListBySearchDepart(list, item.Value);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                    return;
                }
            }
            if (ckbxDesti.Checked)
            {
                if (cbbDestination.SelectedItem != null)
                {
                    CBBItem item = (CBBItem)cbbDestination.SelectedItem;
                    list = FlightDAO.Instance.GetListBySearchDesti(list, item.Value);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                    return;
                }
            }
            if (ckbxDay.Checked)
            {
                list = FlightDAO.Instance.GetListBySearchDay(list, dateTimePicker1.Value);
            }
            ListViewLoad(list);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_FeedbackForm f = new Admin_FeedbackForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
