using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class TicketDAO
    {
        private static TicketDAO instance;

        public static TicketDAO Instance
        {
            get { if (instance == null) instance = new TicketDAO(); return instance; }
            private set { instance = value; }
        }

        public List<TicketDTO> TicketList { get; set; }
        private TicketDAO()
        {
            TicketList = GetAllTicketList();
        }
        public List<TicketDTO> GetAllTicketList()
        {
            List<TicketDTO> list = new List<TicketDTO>();

            string query = "select * from TICKET";

            DataTable data = DataProvider.Instance.GetRecord(query);

            foreach (DataRow item in data.Rows)
            {
                list.Add(new TicketDTO(item));
            }
            return list;
        }
        public List<TicketDTO> GetListTicketPerFlightbyIdPrice(string fl_id, int price_id)
        {
            List<TicketDTO> list = new List<TicketDTO>();
            foreach (TicketDTO i in GetListTicketPerFlight(fl_id))
            {
                if(i.price_id == price_id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<TicketDTO> GetListTicketPerFlightbyIdPrice(List<TicketDTO> listTemp, int price_id)
        {
            List<TicketDTO> list = new List<TicketDTO>();
            foreach (TicketDTO i in listTemp)
            {
                if (i.price_id == price_id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public List<TicketDTO> GetListTicketPerFlight(string fl_id)
        {
            List<TicketDTO> list = new List<TicketDTO>();
            foreach (TicketDTO i in GetAllTicketList())
            {
                if (i.fl_id == fl_id)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public TicketDTO GetTicketByID(int tk_id)
        {
            foreach (TicketDTO i in GetAllTicketList())
            {
                if (i.ticket_id == tk_id)
                {
                    return i;
                }
            }
            return null;
        }
        public List<TicketDTO> GetTicketByUserName(string Username, int so)
        {
            List<TicketDTO> t = new List<TicketDTO>();

            foreach (TicketDTO i in GetAllTicketList())
            {
                int status = FlightDAO.Instance.GetFlightByID(i.fl_id).status;
                if (i.us_username == Username && status == so)
                {
                    t.Add(i);
                }
            }
            //foreach(TicketDTO j in t)
            //{
            //    if(FlightDAO.Instance.Status(j.fl_id) == status)
            //    {
            //        t1.Add(j);
            //    }

            //}
            return t;
        }
        public void AddTicketToDataBase(string fl_id, string username,string name, bool gender, string phone, string address, int seat_number, int price_id)
        {
            string query = String.Format("insert into TICKET values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', {6}, {7})", fl_id, username, name, gender.ToString(), phone, address, seat_number, price_id);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void EditTicketToDataBase(int tk_id, string name, bool gender, string phone, string address, int seat_number, int price_id)
        {
            string query = String.Format("update TICKET set ticket_name = N'{0}',ticket_gender = N'{1}',ticket_mobile = N'{2}',ticket_address = N'{3}', seat_number = {4}, price_id = {5} where ticket_id = N'{6}'", name, gender.ToString(), phone, address, seat_number, price_id, tk_id);
            DataProvider.Instance.ExecuteDB(query);
        }
        public void DeleteTicketFromDataBase(int ticket_id)
        {
            string query = String.Format("delete from TICKET where ticket_id = {0}", ticket_id);
            DataProvider.Instance.ExecuteDB(query);
        }

    }
}
