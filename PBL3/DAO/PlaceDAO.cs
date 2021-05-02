using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class PlaceDAO
    {
        private static PlaceDAO _Instance;
        public static PlaceDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PlaceDAO();
                }
                return _Instance;
            }
            private set { }
        }
        private PlaceDAO()
        { }
        public List<SourceDTO> GetListFrom()
        {
            List<SourceDTO> list = new List<SourceDTO>();

            string query = "select * from SOURCE";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                SourceDTO place = new SourceDTO(item);
                list.Add(place);
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
                DestinationDTO place = new DestinationDTO(item);
                list.Add(place);
            }

            return list;
        }
        public string GetSource(int id)
        {
            List<SourceDTO> list = new List<SourceDTO>();
            string source = null;
            string query = "select * from SOURCE where src_id = " + id;
            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                SourceDTO place = new SourceDTO(item);
                list.Add(place);
            }
            foreach(SourceDTO s in list)
            {
                source = s.src_name;
            }
            return source;
        }
        public string GetDes(int id)
        {
            List<DestinationDTO> list = new List<DestinationDTO>();
            string source = null;
            string query = "select * from DESTINATION where des_id = " + id;
            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                DestinationDTO place = new DestinationDTO(item);
                list.Add(place);
            }
            foreach (DestinationDTO s in list)
            {
                source = s.des_name;
            }
            return source;
        }
    }
}
