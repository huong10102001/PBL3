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

            string query = string.Format("select AIRLINE.airline_name, PLACE.place_name, fl_takeoftime, fl_price, fl_triptype from FLIGHT, AIRLINE,PLACE where fl_triptype = {0} and AIRLINE.airline_id = FLIGHT.airline_id and PLACE.place_id = (select place_id from PLACE where place_name = N'{1}') and fl_source = (select place_id from PLACE where place_name = N'{2}') and fl_takeoff = {3}", trip, from, to, takeoff);

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                FlightSearch fight = new FlightSearch(item);
                list.Add(fight);
            }

            return list;
        }
    }
}
