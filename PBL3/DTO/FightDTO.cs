using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class FightDTO
    {
        public int airline_id { get; set; }
        public int fl_source { get; set; }
        public int fl_destination { get; set; }
        public DateTime time { get; set; }
        public DateTime takeoff { get; set; }
        public DateTime landing { get; set; }
        public int idprice { get; set; }
        public string triptype { get; set; }
        public string description { get; set; }
        public int status { get; set; }
    
        public FightDTO()
        {
            airline_id = 1;
            fl_source = 1;
            fl_destination = 1;
            time = DateTime.Now;
            takeoff = DateTime.Now;
            landing = DateTime.Now;
            idprice = 0;
            triptype = null;
            description = null;
            status = 0;
        }
        public FightDTO(DataRow row)
        {
            this.airline_id = (int)row["airline_id"];
            this.fl_source = (int)row["fl_source"];
            this.fl_destination = (int)row["fl_source"];
            this.time = (DateTime)row["time"];
            this.takeoff = (DateTime)row["takeoff"];
            this.landing = (DateTime)row["landing"];
            this.idprice = (int)row["idprice"];
            this.triptype = row["triptype"].ToString();
            this.description = row["description"].ToString();
            this.status = (int)row["status"];
        }
    }
}
