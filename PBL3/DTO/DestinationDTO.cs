using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class DestinationDTO
    {
        public int des_id { get; set; }
        public string des_name { get; set; }

        public DestinationDTO(int des_id, string des_name)
        {
            this.des_id = des_id;
            this.des_name = des_name;
        }

        public DestinationDTO()
        {
            des_id = 0;
            des_name = null;
        }
        public DestinationDTO(DataRow row)
        {
            this.des_id = Convert.ToInt32(row["des_id"]);
            this.des_name = row["des_name"].ToString();
        }
        public override string ToString()
        {
            return des_name;
        }
    }
}
