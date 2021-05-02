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
    public partial class SeatsBooking : Form
    {
        private int SEAT_NAME;
        private int PRICE_ID;
        private string USERNAME;
        private string ID_FLIGHT;
        private int TICKET_ID;
        private int BTN_WIDTH = 40;
        private int BTN_HEIGHT = 40;
        public SeatsBooking(string fl_id, string username, string type, int ticket_id = -1)
        {
            ID_FLIGHT = fl_id;
            USERNAME = username;
            InitializeComponent();
            LoadSeats(ticket_id);
            LoadCBB();
            switch (type)
            {
                case "ADMIN_ADD":
                    btnConfirm.Click += new EventHandler(AddTicket);
                    lblMode.Text = "Add new ticket";
                    btnConfirm.Text = "Add";
                    break;
                case "ADMIN_EDIT":
                    TICKET_ID = ticket_id;
                    FormInit(ticket_id);
                    btnConfirm.Text = "Edit";
                    btnConfirm.Click += new EventHandler(EditTicket);
                    break;
                case "USER_ADD":
                    btnConfirm.Click += new EventHandler(btnConfirm_Click);
                    break;
            }
            lbText.Text = fl_id + "'S SEATS";
        }
        public void FormInit(int ticket_id)
        {
            TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);

            string lastWord = ticket.ticket_name.Split(' ').Last();
            lblMode.Text = "Edit "+lastWord+"'s ticket";

            if (ticket.price_id == PriceDAO.Instance.PriceList[0].id)
            {
                string txt = "F" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[1].id)
            {
                string txt = "D" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[2].id)
            {
                string txt = "M" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[3].id)
            {
                string txt = "B" + ticket.seat_number;
                lblSeatName.Text = txt;
            }

            SEAT_NAME = ticket.seat_number;
            PRICE_ID = ticket.price_id;
            txbName.Text = ticket.ticket_name;
            txbPhone.Text = ticket.ticket_mobile;
            txbAddress.Text = ticket.ticket_address;
            cbbGender.SelectedIndex = (ticket.ticket_gender) ? 0 : 1;
        }
        public void LoadSeats(int ticket_id)
        {
            for(int i = 1; i <= 6; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = "F" + i;
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(34, 228, 172);
                btn.Click += new EventHandler(FirstButton);
                if (isFirstAvalaible(i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }
                if(ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if(i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[0].id)
                    {
                        btn.BackColor = Color.Tomato;
                    }
                }

                flpFirst.Controls.Add(btn);
            }
            for (int i = 1; i <= 12; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = "D" + i;
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(27, 215, 187);
                btn.Click += new EventHandler(DeltatButton);

                if (isDeltaAvalaible(i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[1].id)
                    {
                        btn.BackColor = Color.Tomato;
                    }
                }

                flpDelta.Controls.Add(btn);
            }
            for (int i = 1; i <= 18; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = "M" + i;
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(20, 201, 203);
                btn.Click += new EventHandler(MainButton);

                if (isMainAvalaible(i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[2].id)
                    {
                        btn.BackColor = Color.Tomato;
                    }
                }

                flpMain.Controls.Add(btn);
            }
            for (int i = 1; i <= 24; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = "B" + i;
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(15, 190, 216);
                btn.Click += new EventHandler(BaseButton);

                if (isBaseAvalaible(i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[3].id)
                    {
                        btn.BackColor = Color.Tomato;
                    }
                }

                flpBase.Controls.Add(btn);
            }
        }
        public void FirstButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[0].id;

        }
        public void DeltatButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[1].id;
        }
        public void MainButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[2].id;
        }
        public void BaseButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[3].id;
        }
        public bool isFirstAvalaible(int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(ID_FLIGHT, PriceDAO.Instance.PriceList[0].id))
            {
                if(i.seat_number == seat_number)
                {
                    return true;
                }           
            }
            return false;
        }
        public bool isDeltaAvalaible(int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(ID_FLIGHT, PriceDAO.Instance.PriceList[1].id))
            {
                if (i.seat_number == seat_number)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isMainAvalaible(int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(ID_FLIGHT, PriceDAO.Instance.PriceList[2].id))
            {
                if (i.seat_number == seat_number)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isBaseAvalaible(int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(ID_FLIGHT, PriceDAO.Instance.PriceList[3].id))
            {
                if (i.seat_number == seat_number)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnConfirm_Click(object sender, EventArgs e) // for user
        {
            if(txbName.Text == "" || txbAddress.Text == ""|| txbPhone.Text == "" || cbbGender.SelectedItem == null || PRICE_ID == 0 || SEAT_NAME == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                TicketDTO ticket = new TicketDTO(ID_FLIGHT, USERNAME, txbName.Text, (cbbGender.SelectedIndex == 0)?true:false, txbPhone.Text, txbAddress.Text, SEAT_NAME, PRICE_ID);
                MessageBox.Show(",ID FLight: "+ID_FLIGHT + ",username: " + USERNAME + ",name: " + txbName.Text + ",address: " + txbAddress.Text + ",phone: " + txbPhone.Text + ",gender: " + ((CBBItem)cbbGender.SelectedItem).Text + ",seat number: " + SEAT_NAME + ",price id: " + PRICE_ID);
            }
        }
        public void AddTicket(object o, EventArgs e) // for admin
        {
            if (txbName.Text == "" || txbAddress.Text == "" || txbPhone.Text == "" || cbbGender.SelectedItem == null || PRICE_ID == 0 || SEAT_NAME == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập dữ liệu hệ thống", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketDAO.Instance.AddTicketToDataBase(ID_FLIGHT, USERNAME, txbName.Text, Convert.ToBoolean(((CBBItem)cbbGender.SelectedItem).Value), txbPhone.Text, txbAddress.Text, SEAT_NAME, PRICE_ID);
                    this.Dispose();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }

            }
        }
        public void EditTicket(object o, EventArgs e)
        {
            if (txbName.Text == "" || txbAddress.Text == "" || txbPhone.Text == "" || cbbGender.SelectedItem == null || PRICE_ID == 0 || SEAT_NAME == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập dữ liệu hệ thống", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TicketDAO.Instance.EditTicketToDataBase(TICKET_ID, txbName.Text, Convert.ToBoolean(((CBBItem)cbbGender.SelectedItem).Value), txbPhone.Text, txbAddress.Text, SEAT_NAME, PRICE_ID);
                    this.Dispose();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }
            }
        }

        public void LoadCBB()
        {
            cbbGender.Items.Add(new CBBItem(1, "Male"));
            cbbGender.Items.Add(new CBBItem(0, "Female"));
            cbbGender.DisplayMember = "Text";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
