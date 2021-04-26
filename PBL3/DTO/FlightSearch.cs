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
        public DateTime time { get; set; }
        public float basiceconmy { get; set; }
        public float maincabin { get; set; }
        public float detalcomfort { get; set; }
        public float firstclass { get; set; }
        public string airlinename { get; set; }

        public FlightSearch()
        {
            timetakeoff = DateTime.Now;
            timelanding = DateTime.Now;
            time = DateTime.Now;
            basiceconmy = 0;
            maincabin = 0;
            detalcomfort = 0;
            firstclass = 0;
            airlinename = null;
        }
        public FlightSearch(DataRow row)
        {
            this.timetakeoff = (DateTime)row["timetakeoff"];
            this.timelanding = (DateTime)row["timelanding"];
            this.time = (DateTime)row["time"];
            this.basiceconmy = (float)row["basiceconmy"];
            this.maincabin = (float)row["maincabin"];
            this.detalcomfort = (float)row["detalcomfort"];
            this.firstclass = (float)row["firstclass"];
            this.airlinename = row["airlinename"].ToString();
        }
    }
}
