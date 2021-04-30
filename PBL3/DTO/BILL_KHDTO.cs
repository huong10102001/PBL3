using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class BILL_KHDTO
    {
        
        public BILL_KHDTO (int id, DateTime? DateOne, DateTime? DateTwo)
        {
            this.ID = id;
            this.DateOne = DateOne;
            this.DateTwo = DateTwo;

        }


        public BILL_KHDTO (DataRow row)
        {
            this.ID = (int)row["bill_id"];
            this.DateOne = (DateTime?)row["DateOne"];

            var dateTwoTemp = row["DateTwo"];
            if (dateTwoTemp.ToString() != "")
                this.DateTwo = (DateTime?)dateTwoTemp;   
        }

        private int id;
        public int ID { get => id; set => id = value; }
        private DateTime? dateOne;
        public DateTime? DateOne { get => dateOne; set => dateOne = value; }
        private DateTime? dateTwo;
        public DateTime? DateTwo { get => dateTwo; set => dateTwo = value; }
    }
}
