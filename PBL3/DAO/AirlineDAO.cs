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

        public List<AirlineDTO> AirlineList { get; set; }
        private AirlineDAO()
        {
            AirlineList = GetAllAirlineList();
        }

        public List<AirlineDTO> GetListAirline()
        {
            List<AirlineDTO> list = new List<AirlineDTO>();

            string query = "select airline_name, airline_index from AIRLINE where airline_name = {0}";

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

            string query = string.Format("select FLIGHT.airline_id, airline_index, airline_name from FLIGHT INNER JOIN AIRLINE ON FLIGHT.airline_id = AIRLINE.airline_id INNER JOIN SOURCE ON FLIGHT.fl_source = SOURCE.src_id INNER JOIN DESTINATION ON FLIGHT.fl_destination = DESTINATION.des_id where src_name = N'{0}' and des_name = N'{1}' and fl_triptype = {2} and fl_status = 0 and CAST(fl_takeoftime AS DATE) = N'{3}'", from, to, trip, takeoff);
            
            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                AirlineDTO place = new AirlineDTO(item);
                list.Add(place);
            }

            return list;
        }
        

        List<AirlineDTO> GetAllAirlineList()
        {
            DataTable data = DataProvider.Instance.GetRecord("SELECT * FROM AIRLINE");
            List<AirlineDTO> list = new List<AirlineDTO>();
            foreach (DataRow i in data.Rows)
            {
                list.Add(new AirlineDTO(i));
            }
            return list;
        }
        public string GetNameByID(int id)
        {
            foreach (AirlineDTO i in AirlineList)
            {
                if (i.airline_id == id)
                {
                    return i.airline_name;
                }
            }
            return "";
        }
        public int GetAirlinePosition(int id)
        {
            int index = 0;
            foreach (AirlineDTO i in AirlineList)
            {
                if (i.airline_id == id)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public float GetAirlineIndexbyID(int id)
        {
            foreach(AirlineDTO i in AirlineList)
            {
                if(i.airline_id == id)
                {
                    return i.airline_index;
                }
            }
            return 0;
        }
    }
}
