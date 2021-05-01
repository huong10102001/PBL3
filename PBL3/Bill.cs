using PBL3.DAO;
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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BILL_KHDAO.Instance.GetBillListByDate(dtpkFrom1.Value, dtpkTo1.Value);
            dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BILL_KHDAO.Instance.GetBillListByFlight(dtpkFrom2.Value, dtpkTo2.Value);
            dataGridView2.Sort(dataGridView2.Columns["Date"], ListSortDirection.Ascending);

        }
    }
}
