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
        public List<AirlineDTO> GetAirlineIndex(int trip, string from, string to, string takeoff)
        {
            List<AirlineDTO> list = new List<AirlineDTO>();

            string query = string.Format("select airline_index from FLIGHT INNER JOIN AIRLINE ON FLIGHT.airline_id = AIRLINE.airline_id INNER JOIN SOURCE ON FLIGHT.fl_source = SOURCE.src_id INNER JOIN DESTINATION ON FLIGHT.fl_destination = DESTINATION.des_id where src_name = N'{0}' and des_name = N'{1}' and fl_triptype = {2} and fl_status = 0 and fl_takeoftime = N'{3}'", from, to, trip, takeoff);

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
