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
        public List<FlightDTO> flightList { get; set; }
        private FlightDAO()
        {
            flightList = GetAllFlightList();
        }
        public List<FlightDTO> GetAllFlightList()
        {
            DataTable data = DataProvider.Instance.GetRecord("SELECT * FROM FLIGHT");
            List<FlightDTO> list = new List<FlightDTO>();
            foreach (DataRow i in data.Rows)
            {
                list.Add(GetFlightByDataRow(i));
            }
            return list;
        }
        public FlightDTO GetFlightByDataRow(DataRow row)
        {
            string fl_id = row["fl_id"].ToString();
            int airline_id = Convert.ToInt32(row["airline_id"]);
            int fl_source = Convert.ToInt32(row["fl_source"]);
            int fl_destination = Convert.ToInt32(row["fl_destination"]);
            DateTime fl_takeoff = Convert.ToDateTime(row["fl_takeoftime"]);
            DateTime fl_landing = Convert.ToDateTime(row["fl_landingtime"]);
            bool fl_triptype = Convert.ToBoolean(row["fl_triptype"]);
            string fl_description = row["fl_description"].ToString();
            int fl_status = Convert.ToInt32(row["fl_status"]);
            int fl_capacity = Convert.ToInt32(row["fl_capacity"]);

            return new FlightDTO(fl_id, airline_id, fl_source, fl_destination, fl_takeoff,fl_landing,fl_triptype,fl_description,fl_status,fl_capacity);
        }
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
        public List<FlightDTO> GetListBySearchID(List<FlightDTO> list, string fl_id)
        {
            List<FlightDTO> listtemp = new List<FlightDTO>();
            foreach (FlightDTO i in list)
            {
                if (i.fl_id.ToLower().Contains(fl_id.ToLower()))
                {
                    listtemp.Add(i);
                }
            }
            return listtemp;
        }
        public List<FlightDTO> GetListBySearchAirline(List<FlightDTO> list, int airline_id)
        {
            List<FlightDTO> listtemp = new List<FlightDTO>();
            foreach (FlightDTO i in list)
            {
                if (i.airline_id == airline_id)
                {
                    listtemp.Add(i);
                }
            }
            return listtemp;
        }
        public List<FlightDTO> GetListBySearchDepart(List<FlightDTO> list, int place_id)
        {
            List<FlightDTO> listtemp = new List<FlightDTO>();
            foreach (FlightDTO i in list)
            {
                if (i.fl_source == place_id)
                {
                    listtemp.Add(i);
                }
            }
            return listtemp;
        }
        public List<FlightDTO> GetListBySearchDesti(List<FlightDTO> list, int place_id)
        {
            List<FlightDTO> listtemp = new List<FlightDTO>();
            foreach (FlightDTO i in list)
            {
                if (i.fl_destination == place_id)
                {
                    listtemp.Add(i);
                }
            }
            return listtemp;
        }
        public List<FlightDTO> GetListBySearchDay(List<FlightDTO> list, DateTime day)
        {
            List<FlightDTO> listtemp = new List<FlightDTO>();
            foreach (FlightDTO i in list)
            {
                if (i.takeoff.Date == day.Date)
                {
                    listtemp.Add(i);
                }
            }
            return listtemp;
        }
        public FlightDTO GetFlightByID(string fl_id)
        {
            foreach (FlightDTO i in flightList)
            {
                if (i.fl_id == fl_id)
                {
                    return i;
                }
            }
            return new FlightDTO();
        }
        public int GetIndexbyFlightID(string fl_id)
        {
            int index = 0;
            foreach(FlightDTO i in flightList)
            {
                if(i.fl_id == fl_id)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public void AddFlighttoDatabase(FlightDTO f)
        {
            flightList.Add(f);
            string query = String.Format("insert into FLIGHT values(N'{0}', {1}, {2}, {3}, '{4}', '{5}', '{6}', N'{7}', {8} ,{9})", f.fl_id, f.airline_id, f.fl_source, f.fl_destination, f.takeoff.ToString(), f.landing.ToString(), f.triptype.ToString(), f.description, f.status, f.capacity);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void EditFlighttoDatabase(FlightDTO f)
        {
            flightList[GetIndexbyFlightID(f.fl_id)] = f;
            string query = String.Format("update FLIGHT set airline_id = {0}, fl_source = {1}, fl_destination = {2}, fl_takeoftime = '{3}', fl_landingtime = '{4}', fl_triptype = '{5}', fl_description = N'{6}', fl_status = {7}, fl_capacity = {8} where fl_id = N'{9}'", f.airline_id, f.fl_source, f.fl_destination, f.takeoff.ToString(), f.landing.ToString(), f.triptype.ToString(), f.description, f.status, f.capacity, f.fl_id);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void DeleteFlightFromDatabase(string fl_id)
        {
            flightList.RemoveAt(GetIndexbyFlightID(fl_id));
            string query = String.Format("delete from FLIGHT where fl_id = N'{0}'", fl_id);
            DataProvider.Instance.ExecuteDB(query);
        }
    }
}
