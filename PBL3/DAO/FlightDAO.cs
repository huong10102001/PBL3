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
       public List<FlightSearch> GetListFight(string trip, string from, string to, string takeoff) 
        {
            int tr = 1, dem = 0;
            if (trip == "Round Trip") tr = 1;
            else tr = 0;

            List<FlightSearch> list = new List<FlightSearch>();
            List<PriceDTO> list1 = PriceDAO.Instance.GetListPrice();
            List<AirlineDTO> index = AirlineDAO.Instance.GetAirlineIndex(tr, from, to, takeoff);
            List<Fight> list3 = new List<Fight>();
            

            string query = string.Format("select airline_name, fl_takeoftime, fl_landingtime from FLIGHT inner join AIRLINE on FLIGHT.airline_id = AIRLINE.airline_id inner join SOURCE on FLIGHT.fl_source = SOURCE.src_id inner join DESTINATION on FLIGHT.fl_destination = DESTINATION.des_id where src_name = N'{0}' and des_name = N'{1}' and fl_triptype = {2} and fl_status = 0 and fl_takeoftime = N'{3}'", from, to, tr, takeoff);
            DataTable data = DataProvider.Instance.GetRecord(query);

            FlightSearch flight = new FlightSearch();

            foreach (DataRow item in data.Rows)
            {
                flight = new FlightSearch(item, PriceDAO.Instance.Tinh(index[dem].airline_index));
                list.Add(flight);

                dem++;
            }

            return list;
        }
    }
}
