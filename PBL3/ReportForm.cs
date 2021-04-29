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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void txtEmail_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == txtEmail)
            {
                txtEmail.Text = "";
            }    
            if (sender == txtFeedback)
            {
                txtFeedback.Text = "";
            }    
            if (sender == txtName)
            {
                txtName.Text = "";
            }    
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string content = txtFeedback.Text;
            DateTime dateTime = DateTime.Now;
            FeedbackDAO.Instance.Feedback("nhi", content);
        }


    }
}
