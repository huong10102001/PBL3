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
    public partial class FlightManagement : Form
    {
        public delegate void setInfomationCallBack(string KEY);
        public setInfomationCallBack setInfomation;

        public FlightManagement()
        {
            InitializeComponent();
        }
        private void BtnAdd(object o, EventArgs e)
        {
            UpdateForm f = new UpdateForm();

            this.setInfomation += new setInfomationCallBack(f.FormInit);

            setInfomation("ADD");

            f.ShowDialog();
        }
        private void BtnEdit(object o, EventArgs e)
        {
            UpdateForm f = new UpdateForm();

            this.setInfomation += new setInfomationCallBack(f.FormInit);

            setInfomation("EDIT");

            f.ShowDialog();
        }
        private void BtnDelete(object o, EventArgs e)
        {
            MessageBox.Show("Delete");
        }
        private void BtnView(object o, EventArgs e)
        {
            MessageBox.Show("View");
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.ShowDialog();
        }
    }
}
