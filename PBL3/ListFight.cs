using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.DAO;

namespace PBL3
{
    public partial class ListFight : UserControl
    {
        public ListFight()
        {
            InitializeComponent();
            SetLabel();
        }

        public string username;
        public string flightID;
        public string id;
        public string timetakeoff;
        public string timelanding;
        public float basiceconmy;
        public float maincabin;
        public float detalcomfort;
        public float firstclass;
        public string airlinename;
        public string time;
        public string _id
        {
            get { return id;  }
            set { id = value; }


        public string _flightID
        {
            get { return flightID; }
            set { flightID = value; }
        }

        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public string _timetakeoff
        {
            get { return timetakeoff; }
            set { timetakeoff = value; Timetakeoff.Text = value; }

        }

        public string _timelanding
        {
            get { return timelanding; }
            set { timelanding = value; Timelanding.Text = value; }

        }
        public float _basiceconmy
        {
            get { return basiceconmy; }
            set { basiceconmy = value; BasicEconmy.Text = value.ToString(); }

        }
        public float _maincabin
        {
            get { return maincabin; }
            set { maincabin = value; MainCabin.Text = value.ToString(); }

        }
        public float _detalcomfort
        {
            get { return detalcomfort; }
            set { detalcomfort = value; DetalComfort.Text = value.ToString(); }

        }
        public float _firstclass
        {
            get { return firstclass; }
            set { firstclass = value; FirstClass.Text = value.ToString(); }

        }
        public string _airlinename
        {
            get { return airlinename; }
            set { airlinename = value; AirlineName.Text = value; }

        }
        public string _time
        {
            get { return time; }
            set { time = value; Time.Text = value; }

        }
        public void SetLabel()
        {
            Timetakeoff.Text = timetakeoff;
            Timelanding.Text = timelanding;
            BasicEconmy.Text = basiceconmy.ToString();
            MainCabin.Text = maincabin.ToString();
            DetalComfort.Text = detalcomfort.ToString();
            FirstClass.Text = firstclass.ToString();
            AirlineName.Text = airlinename;
            Time.Text = time;
        }
        public void Des(string FLIGHT_ID)
        {
            FlightDTO des = FlightDAO.Instance.GetFlightByID(FLIGHT_ID);
            MessageBox.Show(des.description);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Des(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeatsBooking f = new SeatsBooking(flightID , username, "USER_ADD");
            f.ShowDialog();
        }
    }
}
