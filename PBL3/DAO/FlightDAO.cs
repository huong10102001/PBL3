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
            List<FlightSearch> list = new List<FlightSearch>();
            List<PriceDTO> list1 = new List<PriceDTO>();
            List<AirlineDTO> list2 = new List<AirlineDTO>();
            int tr = 0;
            float price = 0;
            if (trip == "Round Trip") tr = 1;
            else tr = 0;
           
            string query = string.Format("select airline_name, fl_takeoftime, fl_landingtime from FLIGHT inner join AIRLINE on FLIGHT.airline_id = AIRLINE.airline_id inner join SOURCE on FLIGHT.fl_source = SOURCE.src_id inner join DESTINATION on FLIGHT.fl_destination = DESTINATION.des_id where src_name = N'{0}' and des_name = N'{1}' and fl_triptype = {2} and fl_status = 0 and fl_takeoftime = N'{3}'", from, to, tr, takeoff);

            DataTable data = DataProvider.Instance.GetRecord(query);

            if(data.Rows.Count <= 0) MessageBox.Show("khong co gi ca");
            foreach (DataRow item in data.Rows)
            {
                FlightSearch fight = new FlightSearch(item);
                list.Add(fight);
            }
           // if (list.Count <= 0) MessageBox.Show("khong co gi ca");

            list1 = PriceDAO.Instance.GetListPrice();
            list2 = AirlineDAO.Instance.GetAirlineIndex(tr, from, to, takeoff);

            foreach (FlightSearch k in list)
            {
                foreach (PriceDTO i in list1)
                {
                    int l = 1;
                    foreach (AirlineDTO j in list2)
                    {
                        price = i.price * j.airline_index;
                        if(l == 1)
                        {
                            k.basiceconmy = price;
                            l++;
                        }
                        else if (l == 2)
                        {
                            k.maincabin = price;
                            l++;
                        }
                        else if (l == 3)
                        {
                            k.detalcomfort = price;
                            l++;
                        }
                        else
                        {
                            k.firstclass = price;
                        }
                    }
                }
            }

            return list;
        }
    }
}
