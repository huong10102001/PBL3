using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DAO
{
    class PriceDAO
    {
        private static PriceDAO instance;

        public static PriceDAO Instance
        {
            get { if (instance == null) instance = new PriceDAO(); return instance; }
            private set { instance = value; }
        }

        public List<PriceDTO> PriceList { get; set; }
        private PriceDAO()
        {
            PriceList = GetListPrice();
        }

        public List<PriceDTO> GetListPrice()
        {
            List<PriceDTO> list = new List<PriceDTO>();

            string query = "select * from PRICE";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                PriceDTO place = new PriceDTO(item);
                list.Add(place);
            }

            return list;
        }
        public List<PriceDTO> Tinh(float index)
        {
           
            List<PriceDTO> list = GetListPrice();
            
            foreach(PriceDTO i in list)
            {
                i.price *= index;
            }
            return list;
        }
        public float GetPriceById(int id)
        {
            float price = 0;
            string query = "select * from PRICE where id = " + id;

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                PriceDTO place = new PriceDTO(item);
                price += place.price;
            }

            return price;
        }
    }
}
