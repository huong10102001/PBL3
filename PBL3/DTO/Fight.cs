using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class Fight
    {
        public DateTime timetakeoff { get; set; }
        public DateTime timelanding { get; set; }
        public string airlinename { get; set; }
        public Fight(DataRow row)
        {
            this.timetakeoff = (DateTime)row["timetakeoff"];
            this.timelanding = (DateTime)row["timelanding"];
            this.airlinename = row["airlinename"].ToString();
        }
    }
}
