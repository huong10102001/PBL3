using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class TicketDTO
    {
        public int ticket_id { get; set; }
        public string fl_id { get; set; }
        public string us_username { get; set; }
        public string ticket_name { get; set; }
        public bool ticket_gender { get; set; }
        public string ticket_mobile { get; set; }
        public string ticket_address { get; set; }
        public int seat_number { get; set; }
        public int price_id { get; set; }

        public TicketDTO()
        {
            fl_id = "";
            us_username = "";
            ticket_name = null;
            ticket_mobile = null;
            ticket_address = null;
        }

        public TicketDTO(string fl_id, string us_id, string ticket_name, bool ticket_gender, string ticket_mobile, string ticket_address, int seat_number, int price_id)
        {
            this.fl_id = fl_id;
            this.us_username = us_id;
            this.ticket_name = ticket_name;
            this.ticket_gender = ticket_gender;
            this.ticket_mobile = ticket_mobile;
            this.ticket_address = ticket_address;
            this.seat_number = seat_number;
            this.price_id = price_id;
        }

        public TicketDTO(DataRow row)
        {
            this.ticket_id = Convert.ToInt32(row["ticket_id"]);
            this.fl_id = row["fl_id"].ToString();
            this.us_username = row["us_username"].ToString();
            this.ticket_name = row["ticket_name"].ToString();
            this.ticket_gender = Convert.ToBoolean(row["ticket_gender"]);
            this.ticket_mobile = row["ticket_mobile"].ToString();
            this.ticket_address = row["ticket_address"].ToString();
            this.seat_number = Convert.ToInt32(row["seat_number"]);
            this.price_id = Convert.ToInt32(row["price_id"]);
        }
    }
}
