using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class SourceDTO
    {
        public int src_id { get; set; }
        public string src_name { get; set; }

        public SourceDTO(int src_id, string src_name)
        {
            this.src_id = src_id;
            this.src_name = src_name;
        }

        public SourceDTO()
        {
            src_id = 0;
            src_name = null;
        }
        public SourceDTO(DataRow row)
        {
            this.src_id = Convert.ToInt32(row["src_id"]);
            this.src_name = row["src_name"].ToString();
        }
    }


}
