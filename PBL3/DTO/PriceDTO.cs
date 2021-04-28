using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class PriceDTO
    {
        public string name { get; set; }
        public float price { get; set; }

        public PriceDTO()
        {
            name = null;
            price = 0;
        }

        public PriceDTO(DataRow row)
        {
            this.name = row["name"].ToString();
            
            this.price = Convert.ToSingle(row["price"]);
        }
    }
}
