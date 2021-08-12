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
    public partial class Admin_FeedbackForm : Form
    {
        public Admin_FeedbackForm()
        {
            InitializeComponent();
        }
        BindingSource feedbacklist = new BindingSource();

        private void Admin_FeedbackForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = FeedbackDAO.Instance.GetFeedback();
            this.dataGridView1.Columns["Username"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            dataGridView1.DataSource = FeedbackDAO.Instance.GetFeedbackByName(name);
            this.dataGridView1.Columns["Username"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FeedbackDAO.Instance.GetFeedback();
            this.dataGridView1.Columns["Username"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
