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

        void LoadListBillByDate(string checkIn, string checkOut)
        {
            dataGridView1.DataSource = BILL_KHDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpk_From_1.Value.ToShortDateString(), dtpk_From_2.Value.ToShortDateString());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
