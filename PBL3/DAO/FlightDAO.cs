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
        public delegate bool Compare(object o1, object o2);
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

            return new FlightDTO(fl_id, airline_id, fl_source, fl_destination, fl_takeoff,fl_landing,fl_triptype,fl_description,fl_status);
        }
        public List<FlightSearch> GetAllFight()
        {
            List<FlightSearch> list = new List<FlightSearch>();
            string query = string.Format("select FLIGHT.fl_id, airline_name, airline_index, fl_takeoftime, fl_landingtime from FLIGHT inner join AIRLINE on FLIGHT.airline_id = AIRLINE.airline_id inner join SOURCE on FLIGHT.fl_source = SOURCE.src_id inner join DESTINATION on FLIGHT.fl_destination = DESTINATION.des_id where fl_status = 0");
            DataTable data = DataProvider.Instance.GetRecord(query);

            FlightSearch flight = new FlightSearch();

            foreach (DataRow item in data.Rows)
            {
                flight = new FlightSearch(item);
                list.Add(flight);
            }

            return list;
        }
        public List<FlightSearch> GetListFight(string trip, string from, string to, string takeoff)
        {
            int tr = 1, dem = 0;
            if (trip == "Round Trip") tr = 1;
            else tr = 0;

            List<FlightSearch> list = new List<FlightSearch>();
            List<PriceDTO> list1 = PriceDAO.Instance.GetListPrice();
            List<AirlineDTO> index = AirlineDAO.Instance.GetAirlineIndex(tr, from, to, takeoff);
            List<Fight> list3 = new List<Fight>();
            

            string query = string.Format("select FLIGHT.fl_id, airline_name, airline_index, fl_takeoftime, fl_landingtime from FLIGHT inner join AIRLINE on FLIGHT.airline_id = AIRLINE.airline_id inner join SOURCE on FLIGHT.fl_source = SOURCE.src_id inner join DESTINATION on FLIGHT.fl_destination = DESTINATION.des_id where src_name = N'{0}' and des_name = N'{1}' and fl_triptype = {2} and fl_status = 0 and CAST(fl_takeoftime AS DATE) = N'{3}'", from, to, tr, takeoff);
            DataTable data = DataProvider.Instance.GetRecord(query);

            FlightSearch flight = new FlightSearch();

            foreach (DataRow item in data.Rows)
            {
                flight = new FlightSearch(item);
                list.Add(flight);

                dem++;
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
        public int Status(string fl_id)
        {
            int status = 0;
            string query = "select * from FLIGHT where fl_id = " + fl_id;
            DataTable data = DataProvider.Instance.GetRecord(query);

            FlightDTO flight = new FlightDTO();

            foreach (DataRow item in data.Rows)
            {
                flight = new FlightDTO(item);
                status = flight.status;
            }

            return status;
        }

        public void Sort(List<FlightSearch> flights, Compare cmp)
        {
            for (int i = 0; i < flights.Count - 1; i++)
            {
                for (int j = i + 1; j < flights.Count; j++)
                {
                    if (cmp(flights[i], flights[j]))
                    {
                        FlightSearch temp = flights[i];
                        flights[i] = flights[j];
                        flights[j] = temp;
                    }
                }
            }
        }
        public void SortBLL(List<FlightSearch> flights, string sort)
        {
            if (sort == "$VND")
            {
                Sort(flights, FlightSearch.CompareByPrice);
            }
            else if (sort == "Time")
                Sort(flights, FlightSearch.CompareByTime);
            else
                Sort(flights, FlightSearch.CompareByTimeCash);
        }
        public void AddFlighttoDatabase(FlightDTO f)
        {
            flightList.Add(f);
            string query = String.Format("insert into FLIGHT values(N'{0}', {1}, {2}, {3}, '{4}', '{5}', '{6}', N'{7}', {8})", f.fl_id, f.airline_id, f.fl_source, f.fl_destination, f.takeoff.ToString(), f.landing.ToString(), f.triptype.ToString(), f.description, f.status);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void EditFlighttoDatabase(FlightDTO f)
        {
            flightList[GetIndexbyFlightID(f.fl_id)] = f;
            string query = String.Format("update FLIGHT set airline_id = {0}, fl_source = {1}, fl_destination = {2}, fl_takeoftime = '{3}', fl_landingtime = '{4}', fl_triptype = '{5}', fl_description = N'{6}', fl_status = {7} where fl_id = N'{8}'", f.airline_id, f.fl_source, f.fl_destination, f.takeoff.ToString(), f.landing.ToString(), f.triptype.ToString(), f.description, f.status, f.fl_id);
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
