using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class TicketDTO
    {
        public int fl_id { get; set; }
        public int us_id { get; set; }
        public string ticket_name { get; set; }
        public string ticket_mobile { get; set; }
        public string ticket_address { get; set; }

        public TicketDTO()
        {
            fl_id = 1;
            us_id = 1;
            ticket_name = null;
            ticket_mobile = null;
            ticket_address = null;
        }
    }
}
