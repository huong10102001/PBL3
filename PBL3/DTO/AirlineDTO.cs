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
        public int airline_id { get; set; }
        public string airline_name { get; set; }
        public float airline_index { get; set; }

        public AirlineDTO(int airline_id, string airline_name, float airline_index)
        {
            this.airline_id = airline_id;
            this.airline_name = airline_name;
            this.airline_index = airline_index;
        }

        public AirlineDTO()
        {
            airline_id = 0;
            airline_name = null;
            airline_index = 0;
        }
        public AirlineDTO(DataRow row)
        {
            airline_id = Convert.ToInt32(row["airline_id"]);
            airline_name = row["airline_name"].ToString();
            airline_index = Convert.ToSingle(row["airline_index"]);
        }
        public override string ToString()
        {
            return airline_index.ToString();
        }
    }
}
