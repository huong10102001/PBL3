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
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();
        }
        public string places;
        public string time;
        public float price;

        public string _places
        {
            get { return places; }
            set { places = value; place.Text = value; }
        }
        public string _time
        {
            get { return time; }
            set { time = value; Time.Text = value; }
        }
        public float _price
        {
            get { return price; }
            set { price = value;}
        }
        public void SetLabel()
        {
            place.Text = places;
            Time.Text = time;
        }
    }
}
