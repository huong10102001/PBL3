using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class SourceDAO
    {
        private static SourceDAO _Instance;
        public static SourceDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SourceDAO();
                }
                return _Instance;
            }
            private set { }
        }
        public List<SourceDTO> SourceList { get; set; }
        private SourceDAO()
        {
            SourceList = GetListFrom();
        }
        public List<SourceDTO> GetListFrom()
        {
            List<SourceDTO> list = new List<SourceDTO>();

            string query = "select * from SOURCE";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                SourceDTO Source = new SourceDTO(item);
                list.Add(Source);
            }

            return list;
        }
        public List<SourceDTO> GetListTo()
        {
            List<SourceDTO> list = new List<SourceDTO>();

            string query = "select * from SOURCE";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                SourceDTO Source = new SourceDTO(item);
                list.Add(Source);
            }

            return list;
        }
        public string GetNameByID(int id)
        {
            foreach (SourceDTO i in SourceList)
            {
                if (i.src_id == id)
                {
                    return i.src_name;
                }
            }
            return "";
        }
        public int GetSourceIndex(int id)
        {
            int index = 0;
            foreach (SourceDTO i in SourceList)
            {
                if (i.src_id == id)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
