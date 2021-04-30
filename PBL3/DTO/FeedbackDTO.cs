using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class FeedbackDTO
    {
        private static FeedbackDTO instance;

        public static FeedbackDTO Instance
        {
            get { if (instance == null) instance = new FeedbackDTO(); return instance; }
            private set { instance = value; }
        }
        private FeedbackDTO() { }

        private string content;
        public string Content { get => content; set => content = value; }

        private DateTime? dateFB;
        public DateTime? DateFB { get => dateFB; set => dateFB = value; }
       

        public FeedbackDTO(string content, DateTime? dateFB, string us_name, string us_email)
        {
            this.Content = content;
            this.DateFB = dateFB;
        }

    public FeedbackDTO(DataRow row)
        {
            this.Content = row["content"].ToString();
            this.DateFB = (DateTime?)row["dateFB"];   
        }
    }
}
