using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class FeedbackDAO
    {
        private static FeedbackDAO instance;

        public static FeedbackDAO Instance
        {
            get { if (instance == null) instance = new FeedbackDAO(); return instance; }
            private set { instance = value; }
        }

        private FeedbackDAO() { }

        
        public FeedbackDTO Feedback( string username, string content )
        {
            string query = string.Format("_InsertFeedBack N'{0}',N'{1}'", username, content);
            DataTable data = DataProvider.Instance.GetRecord(query);
            foreach (DataRow item in data.Rows)
            {
                return new FeedbackDTO(item);
            }
            return null;
        }

        public DataTable GetFeedback()
        {
            string query = string.Format("SELECT FEEDBACK.us_username as [Username], us_name as [Customer Name], us_email as [Customer Email], us_phone as [Customer Phone], content as [Feedback],  dateFB as [Feedback Day] FROM FEEDBACK INNER JOIN USERS ON FEEDBACK.us_username = USERS.us_username");
            return DataProvider.Instance.GetRecord(query);
            
        }
        public DataTable GetFeedbackByName(String username)
        {
            string query = string.Format("SELECT FEEDBACK.us_username as [Username], us_name as [Customer Name], us_email as [Customer Email], us_phone as [Customer Phone], content as [Feedback], dateFB as [Feedback Day] FROM FEEDBACK INNER JOIN USERS ON FEEDBACK.us_username = USERS.us_username WHERE FEEDBACK.us_username= '" + username+"'");
            return DataProvider.Instance.GetRecord(query);

        }
    }
}
