using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class ListFight : UserControl
    {
        public ListFight()
        {
            InitializeComponent();
        }

        public string timetakeoff;
        public string timelanding;
        public float basiceconmy;
        public float maincabin;
        public float detalcomfort;
        public float firstclass;
        public string airlinename;
        public string time;

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
    }
}
