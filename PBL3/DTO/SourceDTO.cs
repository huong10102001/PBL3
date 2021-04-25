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
        public string src_name { get; set; }

        public SourceDTO()
        {
            src_name = null;
        }
        public SourceDTO(DataRow row)
        {
            this.src_name = row["src_name"].ToString();
        }
    }


}
