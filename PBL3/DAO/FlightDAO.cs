using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class FlightDAO
    {
        private static FlightDAO _Instance;
        public static FlightDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FlightDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private FlightDAO()
        { }
       public List<FlightSearch> GetListFight(string trip, string from, string to, DateTime takeoff)
        {
            List<FlightSearch> list = new List<FlightSearch>();
            List<PriceDTO> list1 = new List<PriceDTO>();
            List<AirlineDTO> list2 = new List<AirlineDTO>();
            int tr = 0;
            float price = 0;
            if (trip == "Round Trip") tr = 0;
            else tr = 1;

            string query = string.Format("select fl_takeoftime, fl_landingtime, airline_name from FLIGHT, AIRLINE where fl_triptype = {0} and FLIGHT.airline_id = AIRLINE.airline_id", tr);

            DataTable data = DataProvider.Instance.GetRecord(query);
            list1 = PriceDAO.Instance.GetListPrice();
            list2 = AirlineDAO.Instance.GetListAirline();

            foreach (DataRow item in data.Rows)
            {
                FlightSearch fight = new FlightSearch(item);
                list.Add(fight);
            }
            foreach (FlightSearch k in list)
            {
                foreach (PriceDTO i in list1)
                {
                    foreach (AirlineDTO j in list2)
                    {
                        i.price *= j.airline_index;
                    }
                }
            }

            return list;
        }
    }
}
