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

            string query = "select * from AIRLINE where airline_name = {0}";

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
