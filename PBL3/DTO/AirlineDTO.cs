using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class AirlineDTO
    {
        public string airline_name { get; set; }
        public float airline_index { get; set; }
        public AirlineDTO()
        {
            airline_name = null;
            airline_index = 0;
        }
        public AirlineDTO(DataRow row)
        {
            airline_name = row["airline_name"].ToString();
            airline_index = Convert.ToSingle(row["airline_index"]);
        }
        public override string ToString()
        {
            return airline_index.ToString();
        }
    }
}
