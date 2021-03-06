using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class FlightDTO
    {
        public string fl_id { get; set; }
        public int airline_id { get; set; }
        public int fl_source { get; set; }
        public int fl_destination { get; set; }
        public DateTime takeoff { get; set; }
        public DateTime landing { get; set; }
        public int idprice { get; set; }
        public bool triptype { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public int capacity { get; set; }
        public string id_roundtrip { get; set; }

        public FlightDTO()
        {
            id_roundtrip = null;
            airline_id = 1;
            fl_source = 1;
            fl_destination = 1;
            takeoff = DateTime.Now;
            landing = DateTime.Now;
            idprice = 0;
            triptype = false;
            description = null;
            status = 0;
        }
        public FlightDTO(DataRow row)
        {
            this.id_roundtrip = row["id_roundtrip"].ToString();
            this.airline_id = (int)row["airline_id"];
            this.fl_source = (int)row["fl_source"];
            this.fl_destination = (int)row["fl_source"];
            this.takeoff = (DateTime)row["fl_takeoftime"];
            this.landing = (DateTime)row["fl_landingtime"];
            this.triptype = Convert.ToBoolean(row["fl_triptype"]);
            this.description = row["fl_description"].ToString();
            this.status = (int)row["fl_status"];
        }

        public FlightDTO(string fl_id, int airline_id, int fl_source, int fl_destination, DateTime takeoff, DateTime landing, bool triptype, string description, int status, string id_roundtrip)
        {
            this.fl_id = fl_id;
            this.airline_id = airline_id;
            this.fl_source = fl_source;
            this.fl_destination = fl_destination;
            this.takeoff = takeoff;
            this.landing = landing;
            this.triptype = triptype;
            this.description = description;
            this.status = status;
            this.id_roundtrip = id_roundtrip;
        }
    }
}
