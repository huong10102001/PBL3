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
        public void setname(String name)
        {
            button9.Text = name;
        }
        public void setvalue(String from, String to, String date)
        {
            comboBox_From.Text = from;
            comboBox_To.Text = to;
            dateTimePicker1.Value = Convert.ToDateTime(date).Date;
        }
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
            string Trip = (comboBox_Trip.SelectedItem).ToString();
            string From = (comboBox_From.SelectedItem).ToString();
            string To = (comboBox_To.SelectedItem).ToString();
            string Datetakeoff = "2021-08-03 00:00:00.000";
                //dateTimePicker1.Value.ToShortDateString();
            //MessageBox.Show(Datetakeoff);

            List<FlightSearch> list = FlightDAO.Instance.GetListFight(Trip, From, To, Datetakeoff);
            //if (list.Count <= 0) MessageBox.Show("khong co gi ca");

            foreach(FlightSearch i in list)
            {
                ListFight[] listFights = new ListFight[list.Count];
                for (int j = 0; j < listFights.Length; j++)
                {
                    listFights[j] = new ListFight();
                    listFights[j].timetakeoff = i.timetakeoff.ToShortTimeString();
                    listFights[j].timelanding = i.timelanding.ToShortTimeString();
                    listFights[j].basiceconmy = i.basiceconmy;
                    listFights[j].maincabin = i.maincabin;
                    listFights[j].detalcomfort = i.detalcomfort;
                    listFights[j].firstclass = i.firstclass;
                    listFights[j].airlinename = i.airlinename;
                    listFights[j].time = i.time.ToShortTimeString();
                    flowLayoutPanel1.Controls.Add(listFights[j]);
                }
            }    
            
        }

     
        /*public void populateItems(FlightSearch i)
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
}*/
    }
}
