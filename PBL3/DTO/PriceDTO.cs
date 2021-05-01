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
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

        public PriceDTO(int id,string name, float price)
        {
            this.name = name;
            this.price = price;
            this.id = id;
        }

        public PriceDTO()
        {
            name = null;
            price = 0;
            id = 0;
        }

        public PriceDTO(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.name = row["name"].ToString();
            this.price = Convert.ToSingle(row["price"]);
        }
    }
}
