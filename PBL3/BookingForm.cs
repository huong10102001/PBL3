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
        private bool isCollapsed;
        public BookingForm()
        {
            InitializeComponent();
            SetCBB();
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
            f.ShowDialog();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            FlightTicketForm f = new FlightTicketForm();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Trip = ((CBBItem)comboBox_From.SelectedItem).Value.ToString();
            string From = ((CBBItem)comboBox_From.SelectedItem).Value.ToString();
            string To = ((CBBItem)comboBox_From.SelectedItem).Value.ToString();
            DateTime Datetakeoff = Convert.ToDateTime(((CBBItem)comboBox_From.SelectedItem).Value);

            List<FightSearch> list = FightDAO.Instance.GetListFight(Trip, From, To, Datetakeoff);
            foreach(FightSearch i in list)
            {
                populateItems(i.timetakeoff, i.timelanding, i.basiceconmy, i.maincabin, i.detalcomfort, i.firstclass, i.airlinename, i.time);
            }    
            
        }
        public void populateItems(DateTime takeoff, DateTime landing, float basiceconmy, float maincabin, float detalcomfort, float firstclass, string airlinename, DateTime time)
        {
            ListFight[] listFights = new ListFight[20];
            for(int i = 0; i < listFights.Length; i++)
            {
                listFights[i] = new ListFight();
                listFights[i].timetakeoff = takeoff.ToShortTimeString();
                listFights[i].timelanding = landing.ToShortTimeString();
                listFights[i].basiceconmy = basiceconmy;
                listFights[i].maincabin = maincabin;
                listFights[i].detalcomfort = detalcomfort;
                listFights[i].firstclass = firstclass;
                listFights[i].airlinename = airlinename;
                listFights[i].time = time.ToShortTimeString();
                flowLayoutPanel1.Controls.Add(listFights[i]);
            }
        }
    }
}
