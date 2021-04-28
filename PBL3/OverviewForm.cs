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
    public partial class OverviewForm : Form
    {
        public delegate void passDulieu(String from, String to, String date);
        public passDulieu pass;


        public OverviewForm()
        {
            InitializeComponent();
            SetCBB();
        }

        public void SetCBB()
        {
            List<SourceDTO> listfrom = PlaceDAO.Instance.GetListFrom();
            cbbFrom.DataSource = listfrom;
            cbbFrom.DisplayMember = "src_name";

            List<DestinationDTO> listto = PlaceDAO.Instance.GetListTo();
            cbbTo.DataSource = listto;
            cbbTo.DisplayMember = "des_name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OverviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        

        private void btnSignup_Click(object sender, EventArgs e)
        {
            String From = cbbFrom.Text;
            String To = cbbTo.Text;
            String Date = dateTimePicker1.Value.ToShortDateString();
            LoginForm f = new LoginForm();
            this.pass += new passDulieu(f.setvalue);
            pass(From, To, Date);
            this.Hide();
            f.ShowDialog();
        }


    }
}
