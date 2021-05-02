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
    public partial class ReportForm : Form
    {
        private string USERNAME;
        public ReportForm()
        {
            InitializeComponent();
        }
        public void setUserId(string CUSTOMER_ID)
        {
            USERNAME = CUSTOMER_ID;
            this.label7.Text = CUSTOMER_ID;

            AccountDTO acc = AccountDAO.Instance.GetAccountByUserName(USERNAME);
            txtEmail.Text = acc.Email;
            txtName.Text = acc.Name;

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
            string user = label7.Text;
            FeedbackDAO.Instance.Feedback(user, content);
            MessageBox.Show("Thank you for your feedback! / Cảm ơn quý khách đã feedback cho chúng tôi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
