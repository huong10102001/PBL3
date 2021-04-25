using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class AirlineDAO
    {
        private static AirlineDAO instance;

        public static AirlineDAO Instance
        {
            get { if (instance == null) instance = new AirlineDAO(); return instance; }
            private set { instance = value; }
        }

        private AirlineDAO() { }

        public List<AirlineDTO> GetListAirline()
        {
            List<AirlineDTO> list = new List<AirlineDTO>();

            string query = "select * from AIRLINE where airline_name = {0}";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                AirlineDTO place = new AirlineDTO(item);
                list.Add(place);
            }

            return list;
        }
    }
}
