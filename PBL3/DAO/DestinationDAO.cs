using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class DestinationDAO
    {
        private static DestinationDAO _Instance;
        public static DestinationDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DestinationDAO();
                }
                return _Instance;
            }
            private set { }
        }
        public List<DestinationDTO> DestinationList { get; set; }
        private DestinationDAO()
        {
            DestinationList = GetListFrom();
        }
        public List<DestinationDTO> GetListFrom()
        {
            List<DestinationDTO> list = new List<DestinationDTO>();

            string query = "select * from DESTINATION";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                DestinationDTO Destination = new DestinationDTO(item);
                list.Add(Destination);
            }

            return list;
        }
        public List<DestinationDTO> GetListTo()
        {
            List<DestinationDTO> list = new List<DestinationDTO>();

            string query = "select * from DESTINATION";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                DestinationDTO Destination = new DestinationDTO(item);
                list.Add(Destination);
            }

            return list;
        }
        public string GetNameByID(int id)
        {
            foreach (DestinationDTO i in DestinationList)
            {
                if (i.des_id == id)
                {
                    return i.des_name;
                }
            }
            return "";
        }
        public int GetDestinationIndex(int id)
        {
            int index = 0;
            foreach (DestinationDTO i in DestinationList)
            {
                if (i.des_id == id)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
