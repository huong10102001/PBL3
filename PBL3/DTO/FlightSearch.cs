using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class FlightSearch
    {
        public DateTime timetakeoff { get; set; }
        public DateTime timelanding { get; set; }
        public TimeSpan time { get; set; }
        public string fl_id { get; set; }
        public float index { get; set; }
        public float basiceconmy { get; set; }
        public float maincabin { get; set; }
        public float detalcomfort { get; set; }
        public float firstclass { get; set; }
        public string airlinename { get; set; }

        public FlightSearch()
        {
            fl_id = "";
            index = 0;
            timetakeoff = DateTime.Now;
            timelanding = DateTime.Now;
            time = TimeSpan.Zero;
            basiceconmy = 0;
            maincabin = 0;
            detalcomfort = 0;
            firstclass = 0;
            airlinename = null;
        }
        public FlightSearch(DataRow row)
        {
            this.fl_id = row["fl_id"].ToString();
            this.timetakeoff = (DateTime)row["fl_takeoftime"];
            this.timelanding = (DateTime)row["fl_landingtime"];
            this.time = timelanding - timetakeoff;
            this.airlinename = row["airline_name"].ToString();
            this.index = Convert.ToSingle(row["airline_index"]);
            this.basiceconmy = 0;
            this.maincabin = 0;
            this.detalcomfort = 0;
            this.firstclass = 0;
        }
    }
}
