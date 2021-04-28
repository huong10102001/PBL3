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
        public string des_name { get; set; }

        public DestinationDTO()
        {
            des_name = null;
        }
        public DestinationDTO(DataRow row)
        {
            this.des_name = row["des_name"].ToString();
        }
        public override string ToString()
        {
            return des_name;
        }
    }
}
