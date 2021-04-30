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
    public partial class BookingForm : Form
    {
        public delegate void CustomerId(string USERNAME);
        public CustomerId customerId;
        public delegate void FlightId(string FlightId);
        public FlightId flightId;
        

        private string USERNAME;
        private bool isCollapsed;
        string user1 = null;
        List<FlightSearch> list = FlightDAO.Instance.GetAllFight();

        public void setUserID(string User)
        {
            user1 = User;
           
        }

        public delegate void UserName2(String username);
        public UserName2 user;

        public delegate void passFlight(String Des1, String Des2, String Des3, String date1, String date2, String date3, String date4);
        public passFlight pass; 

        public delegate void Ten2(String name);
        public Ten2 ten2;

        public void setname(String name)
        {
            button9.Text = name;
        }
        public void setvalue(String from, String to, String date )
        {
            if(from == null || to == null || date == null)
            {
                comboBox_From.SelectedItem = null;
                comboBox_To.SelectedItem = null;
            }
            else
            {
                comboBox_From.Text = from;
                comboBox_To.Text = to;
                dateTimePicker1.Value = Convert.ToDateTime(date).Date;
            }         
        }

        string u;
        public void setUserName(String username)
        {
            u = username;
        }
        public BookingForm(string username)
        {
            USERNAME = username;
            InitializeComponent();
            LoadFlightListAvailable();
            SetCBB();
           // this.flightId += new FlightId
        }
        public void SetLabel(string from, string to, string dateoff)
        {
            string str = from + " to " + to;
            label9.Text = str;
            label10.Text = dateoff;
        }
        public void SetCBB()
        {
            List<SourceDTO> listfrom = PlaceDAO.Instance.GetListFrom();
            comboBox_From.DataSource = listfrom;
            comboBox_From.DisplayMember = "src_name";

            List<DestinationDTO> listto = PlaceDAO.Instance.GetListTo();
            comboBox_To.DataSource = listto;
            comboBox_To.DisplayMember = "des_name";
        }
        public void EX()
        {
            for (int i = 0; i < 10; i++)
            {
                string istr = i.ToString();

                TextBox newButton = new TextBox();
                newButton.Text = istr;
                newButton.Name = "btn" + istr;
                newButton.Visible = true;
                newButton.BackColor = Color.AliceBlue;
                newButton.ForeColor = Color.Black;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button9.Image = global::PBL3.Properties.Resources.Capture5;
                panel9.Height += 10;
                if (panel9.Size == panel9.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button9.Image = global::PBL3.Properties.Resources.Capture4;
                panel9.Height -= 10;
                if (panel9.Size == panel9.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            InfoForm f = new InfoForm();
            this.customerId += new CustomerId(f.Form);
            customerId(user1);
            f.ShowDialog();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            FlightTicketForm f = new FlightTicketForm();
            this.customerId += new CustomerId(f.setUserId);
            customerId(user1);
            f.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            Dispose();
        }

        public void LoadFlightListAvailable()
        {
            List<PriceDTO> priceList = PriceDAO.Instance.PriceList;

           // List<FlightSearch> list = FlightDAO.Instance.GetAllFight();

            ListFight[] listFights = new ListFight[list.Count];

            foreach (FlightSearch i in list)
            {
                int s = 0;
                for (int j = 0; j < listFights.Length; j++)
                {

                    listFights[j] = new ListFight();
                    listFights[j].id = i.id;
                    listFights[j].flightID = i.fl_id;
                    listFights[j].username = USERNAME;
                    listFights[j].timetakeoff = i.timetakeoff.ToShortTimeString();
                    listFights[j].timelanding = i.timelanding.ToShortTimeString();
                    listFights[j].basiceconmy = priceList[0].price * i.index;
                    listFights[j].maincabin = priceList[1].price * i.index;
                    listFights[j].detalcomfort = priceList[2].price * i.index;
                    listFights[j].firstclass = priceList[3].price * i.index;
                    listFights[j].airlinename = i.airlinename;
                    listFights[j].time = i.time.ToString();
                    listFights[j].SetLabel();

                }
                flowLayoutPanel1.Controls.Add(listFights[s]);
                s++;
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if(comboBox_From.SelectedItem == null || comboBox_To.SelectedItem == null || comboBox_Trip.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon day du thong tin!");
            }
            else
            {
                string Trip = (comboBox_Trip.SelectedItem).ToString();
                string From = (comboBox_From.SelectedItem).ToString();
                string To = (comboBox_To.SelectedItem).ToString();
                string Datetakeoff = dateTimePicker1.Value.ToShortDateString();

                SetLabel(From, To, Datetakeoff);
                List<FlightSearch> listfight = FlightDAO.Instance.GetListFight(Trip, From, To, Datetakeoff);
                list = listfight;

                ListFight[] listFights = new ListFight[listfight.Count];

                List<PriceDTO> priceList = PriceDAO.Instance.PriceList;

                foreach (FlightSearch i in listfight)
                {
                    int s = 0;
                    for (int j = 0; j < listFights.Length; j++)
                    {
                        
                        listFights[j] = new ListFight();
                        listFights[j].id = i.id;
                        listFights[j].username = USERNAME;
                        listFights[j].flightID = i.fl_id;
                        listFights[j].timetakeoff = i.timetakeoff.ToShortTimeString();
                        listFights[j].timelanding = i.timelanding.ToShortTimeString();
                        listFights[j].basiceconmy = priceList[0].price * i.index;
                        listFights[j].maincabin = priceList[1].price * i.index;
                        listFights[j].detalcomfort = priceList[2].price * i.index;
                        listFights[j].firstclass = priceList[3].price * i.index;
                        listFights[j].airlinename = i.airlinename;
                        listFights[j].time = i.time.ToString();
                        listFights[j].SetLabel();

                    }
                    flowLayoutPanel1.Controls.Add(listFights[s]);
                    s++;
                }
            

            }

        }
        public void SortBy(string sort)
        {
            List<PriceDTO> priceList = PriceDAO.Instance.PriceList;
            
            foreach (FlightSearch f in list)
            {
                f.basiceconmy = priceList[0].price * f.index;
                f.maincabin = priceList[1].price * f.index;
                f.detalcomfort = priceList[2].price * f.index;
                f.firstclass = priceList[3].price * f.index;
            }
            FlightDAO.Instance.SortBLL(list, sort);

            ListFight[] listFights = new ListFight[list.Count];
            flowLayoutPanel1.Controls.Clear();
            foreach (FlightSearch i in list)
            {
                int s = 0;
                for (int j = 0; j < listFights.Length; j++)
                {

                    listFights[j] = new ListFight();
                    listFights[j].id = i.id;
                    listFights[j].timetakeoff = i.timetakeoff.ToShortTimeString();
                    listFights[j].timelanding = i.timelanding.ToShortTimeString();
                    listFights[j].basiceconmy = i.basiceconmy;
                    listFights[j].maincabin = i.maincabin;
                    listFights[j].detalcomfort = i.detalcomfort;
                    listFights[j].firstclass = i.firstclass;
                    listFights[j].airlinename = i.airlinename;
                    listFights[j].time = i.time.ToString();
                    listFights[j].SetLabel();

                }
                flowLayoutPanel1.Controls.Add(listFights[s]);
                s++;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                SortBy(radioButton1.Text);
            }
            else if(radioButton2.Checked)
            {
                SortBy(radioButton2.Text);
            }
            else
            {
                SortBy(radioButton3.Text);
            }
        }
    }
}
