using PBL3.DAO;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FlightTicketForm : Form
    {
        string user = null;
        public void setUserID(string User)
        {
            user = User;

        }
        public FlightTicketForm()
        {
            InitializeComponent();
            Load();
        }
        public void setUserId(string CUSTOMER_ID)
        {
            this.user = CUSTOMER_ID;
            
        }
        public void Load()
        {
            dataGridView1.DataSource = TicketDAO.Instance.GetTicketByUserName(user, 0);
            dataGridView1.Columns["ticket_id"].Visible = false;

            dataGridView2.DataSource = TicketDAO.Instance.GetTicketByUserName(user, 1);
            dataGridView2.Columns["ticket_id"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
