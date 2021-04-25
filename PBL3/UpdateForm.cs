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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void FormInit(string KEY)
        {
            switch (KEY)
            {
                case ("ADD"):

                    lbText.Text = "ADDING INFORMATION";

                    break;
                case ("EDIT"):

                    lbText.Text = "EDITING INFORMATION";

                    break;
            }
        }
    }
}
