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
        public delegate void Info_Ticket(TicketDTO ticket);
        public Info_Ticket info_ticket;
        private int SEAT_NAME;
        private int PRICE_ID;
        private string USERNAME;
        private string ID_FLIGHT;
        private string ID_FLIGHT1;
        private int TICKET_ID;
        private int BTN_WIDTH = 40;
        private int BTN_HEIGHT = 40;
        private int COUNT = 0;
        private string TYPE;
        private bool IsRoundTrip = false;
        private bool IsBackTrip = false;
        private List<TicketDTO> PassList;
        private List<TicketDTO> TempList;
        private List<TicketDTO> PassList1;
        private List<TicketDTO> TempList1;
        Color color1 = Color.FromArgb(34, 228, 172);
        Color color2 = Color.FromArgb(27, 215, 187);
        Color color3 = Color.FromArgb(20, 201, 203);
        Color color4 = Color.FromArgb(15, 190, 216);
        public SeatsBooking(string fl_id, string username, string type, int ticket_id = -1)
        {
            ID_FLIGHT = fl_id;
            USERNAME = username;
            PassList1 = new List<TicketDTO>();
            TempList1 = new List<TicketDTO>();
            PassList = new List<TicketDTO>();
            TempList = new List<TicketDTO>();
            //COUNT = TicketDAO.Instance.GetListTicketPerFlight(fl_id).Count;
            FlightDTO fl = FlightDAO.Instance.GetFlightByID(fl_id);

            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlight(fl_id))
            {
                TempList.Add(i);
            }

            if(fl.id_roundtrip != "")
            {
                IsRoundTrip = true;
                ID_FLIGHT1 = fl.id_roundtrip;
                foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlight(fl.id_roundtrip))
                {
                    TempList1.Add(i);
                }
            }

            
            
            InitializeComponent();


            LoadSeats(TempList, ticket_id);
            LoadListView(PassList);

            LoadCBB();

            

            switch (type)
            {
                case "ADMIN_ADD":
                    btnConfirm.Click += new EventHandler(btnConfirm_Click);
                    lblMode.Text = "ADMIN ADD MODE";
                    btnPayment.Text = "Add";
                    TYPE = type;
                    break;
                case "ADMIN_EDIT":
                    TICKET_ID = ticket_id;
                    FormInit(ticket_id);
                    lblMode.Text = "ADMIN EDIT MODE";
                    btnConfirm.Text = "Edit";
                    btnPayment.Enabled = false;
                    btnDelete.Enabled = false;
                    listView1.Enabled = false;
                    btnConfirm.Click += new EventHandler(EditTicket);
                    break;
                case "USER_ADD":
                    btnConfirm.Click += new EventHandler(btnConfirm_Click);
                    TYPE = type;
                    break;
            }
            lbText.Text = fl_id + "'S SEATS";
            if (IsRoundTrip)
            {
                btnPayment.Text = "Next to back-trip";
                lbText.Text = ID_FLIGHT + "'S SEATS --- FIRST TRIP";
            }
        }
        public void FormInit(int ticket_id)
        {
            TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);

            string lastWord = ticket.ticket_name.Split(' ').Last();
            lblMode.Text = "Edit " + lastWord + "'s ticket";

            if (ticket.price_id == PriceDAO.Instance.PriceList[3].id)
            {
                string txt = "F" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[2].id)
            {
                string txt = "D" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[1].id)
            {
                string txt = "M" + ticket.seat_number;
                lblSeatName.Text = txt;
            }
            else if (ticket.price_id == PriceDAO.Instance.PriceList[0].id)
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
        public void LoadSeats(List<TicketDTO> ticketList, int ticket_id = -1)
        {
            flpFirst.Controls.Clear();
            flpDelta.Controls.Clear();
            flpMain.Controls.Clear();
            flpBase.Controls.Clear();

            for (int i = 1; i <= 6; i++)
            {
                Button btn = new Button();
                btn.Tag = i;
                btn.Text = "F" + i;
                btn.Width = BTN_WIDTH;
                btn.Height = BTN_HEIGHT;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = color1;
                btn.Click += new EventHandler(FirstButton);
                btn.GotFocus += new EventHandler(BtnFocus);
                btn.LostFocus += new EventHandler(LostFirst);
                if (isFirstAvalaible(ticketList, i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }
                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[3].id)
                    {
                        btn.BackColor = Color.DarkGray;
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
                btn.BackColor = color2;
                btn.Click += new EventHandler(DeltatButton);
                btn.GotFocus += new EventHandler(BtnFocus);
                btn.LostFocus += new EventHandler(LostDelta);

                if (isDeltaAvalaible(ticketList, i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[2].id)
                    {
                        btn.BackColor = Color.DarkGray;
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
                btn.BackColor = color3;
                btn.Click += new EventHandler(MainButton);
                btn.GotFocus += new EventHandler(BtnFocus);
                btn.LostFocus += new EventHandler(LostMain);

                if (isMainAvalaible(ticketList, i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[1].id)
                    {
                        btn.BackColor = Color.DarkGray;
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
                btn.BackColor = color4;
                btn.Click += new EventHandler(BaseButton);
                btn.GotFocus += new EventHandler(BtnFocus);
                btn.LostFocus += new EventHandler(LostBase);

                if (isBaseAvalaible(ticketList, i))
                {
                    btn.BackColor = Color.Pink;
                    btn.Enabled = false;
                }

                if (ticket_id != -1)
                {
                    TicketDTO ticket = TicketDAO.Instance.GetTicketByID(ticket_id);
                    if (i == ticket.seat_number && ticket.price_id == PriceDAO.Instance.PriceList[0].id)
                    {
                        btn.BackColor = Color.DarkGray;
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
            PRICE_ID = PriceDAO.Instance.PriceList[3].id;

        }
        public void DeltatButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[2].id;
        }
        public void MainButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[1].id;
        }
        public void BaseButton(object o, EventArgs e)
        {
            Button btn = (Button)o;
            lblSeatName.Text = btn.Text;

            SEAT_NAME = Convert.ToInt32(btn.Tag);
            PRICE_ID = PriceDAO.Instance.PriceList[0].id;
        }
        public void BtnFocus(object o, EventArgs e)
        {
            Button btn = (Button)o;
            btn.BackColor = Color.Tomato;
        }
        public void LostFirst(object o, EventArgs e)
        {
            Button btn = (Button)o;
            btn.BackColor = color1;
        }
        public void LostDelta(object o, EventArgs e)
        {
            Button btn = (Button)o;
            btn.BackColor = color2;
        }
        public void LostMain(object o, EventArgs e)
        {
            Button btn = (Button)o;
            btn.BackColor = color3;
        }
        public void LostBase(object o, EventArgs e)
        {
            Button btn = (Button)o;
            btn.BackColor = color4;
        }
        public bool isFirstAvalaible(List<TicketDTO> list,  int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(list, PriceDAO.Instance.PriceList[3].id))
            {
                if(i.seat_number == seat_number)
                {
                    return true;
                }           
            }
            return false;
        }
        public bool isDeltaAvalaible(List<TicketDTO> list, int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(list,  PriceDAO.Instance.PriceList[2].id))
            {
                if (i.seat_number == seat_number)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isMainAvalaible(List<TicketDTO> list, int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(list, PriceDAO.Instance.PriceList[1].id))
            {
                if (i.seat_number == seat_number)
                {
                    return true;
                }
            }
            return false;
        }
        public bool isBaseAvalaible(List<TicketDTO> list, int seat_number)
        {
            foreach (TicketDTO i in TicketDAO.Instance.GetListTicketPerFlightbyIdPrice(list, PriceDAO.Instance.PriceList[0].id))
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
            if(txbName.Text == "" || txbName.Text.Contains("'") || txbAddress.Text == ""|| txbAddress.Text.Contains("'") || txbPhone.Text == "" || txbPhone.Text.Contains("'") || cbbGender.SelectedItem == null || PRICE_ID == 0 || SEAT_NAME == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!/ Thông tin nhập không hợp lệ");
            }
            else
            {

                //MessageBox.Show(",ID FLight: "+ID_FLIGHT + ",username: " + USERNAME + ",name: " + txbName.Text + ",address: " + txbAddress.Text + ",phone: " + txbPhone.Text + ",gender: " + ((CBBItem)cbbGender.SelectedItem).Text + ",seat number: " + SEAT_NAME + ",price id: " + PRICE_ID);

                if (IsBackTrip)
                {
                    TicketDTO ticket = new TicketDTO(ID_FLIGHT1, USERNAME, txbName.Text, (cbbGender.SelectedIndex == 0) ? true : false, txbPhone.Text, txbAddress.Text, SEAT_NAME, PRICE_ID);

                    PassList1.Add(ticket);
                    TempList1.Add(ticket);
                    LoadSeats(TempList1);
                    LoadListView(PassList1);
                }
                else
                {
                    TicketDTO ticket = new TicketDTO(ID_FLIGHT, USERNAME, txbName.Text, (cbbGender.SelectedIndex == 0) ? true : false, txbPhone.Text, txbAddress.Text, SEAT_NAME, PRICE_ID);

                    PassList.Add(ticket);
                    TempList.Add(ticket);
                    LoadSeats(TempList);
                    LoadListView(PassList);
                }
                
                txbAddress.Text = "";
                txbName.Text = "";
                txbPhone.Text = "";
                lblSeatName.Text = "Choose an available seat!";

                SEAT_NAME = 0;
                PRICE_ID = 0;

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

        public void LoadListView(List<TicketDTO> list)
        {
            listView1.Items.Clear();
            foreach (TicketDTO i in list)
            {
                ListViewItem lvsItem = new ListViewItem(i.ticket_name);
                lvsItem.SubItems.Add((i.ticket_gender)?"Male":"Female");
                lvsItem.SubItems.Add(i.ticket_mobile);
                lvsItem.SubItems.Add(i.ticket_address);

                List<PriceDTO> PriceList = PriceDAO.Instance.PriceList;
                int first = PriceList[3].id;
                int delta = PriceList[2].id;
                int main = PriceList[1].id;
                int econo = PriceList[0].id;

                if (i.price_id == first)
                {
                    string txt = "F" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    //string price = "" + PriceDAO.Instance.PriceList[0].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    //lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == delta)
                {
                    string txt = "D" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    //string price = "" + PriceDAO.Instance.PriceList[1].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    //lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == main)
                {
                    string txt = "M" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    //string price = "" + PriceDAO.Instance.PriceList[2].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    //lvsItem.SubItems.Add(price);
                }
                else if (i.price_id == econo)
                {
                    string txt = "B" + i.seat_number;
                    lvsItem.SubItems.Add(txt);

                    //string price = "" + PriceDAO.Instance.PriceList[3].price * AirlineDAO.Instance.GetAirlineIndexbyID(FlightDAO.Instance.GetFlightByID(i.fl_id).airline_id);
                    //lvsItem.SubItems.Add(price);
                }
                listView1.Items.Add(lvsItem);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsBackTrip)
            {
                LoadSeats(TempList);
                LoadListView(PassList);
                IsBackTrip = false;
                IsRoundTrip = true;
                btnPayment.Text = "Next to back-trip";
                btnCancel.Text = "Cancel";
                lbText.Text = ID_FLIGHT + "'S SEATS --- FIRST TRIP";

                SEAT_NAME = 0;
                PRICE_ID = 0;
                lblSeatName.Text = "Choose an available seat!";
            }
            else
            {
                this.Dispose();
            }
            
        }
        private void DisposeForm()
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);

                if (IsBackTrip)
                {
                    COUNT = TicketDAO.Instance.GetListTicketPerFlight(ID_FLIGHT1).Count;

                    PassList1.RemoveAt(index);
                    TempList1.RemoveAt(COUNT + index);

                    SEAT_NAME = 0;
                    PRICE_ID = 0;
                    lblSeatName.Text = "Choose an available seat!";

                    LoadListView(PassList1);
                    LoadSeats(TempList1);
                }
                else
                {
                    COUNT = TicketDAO.Instance.GetListTicketPerFlight(ID_FLIGHT).Count;

                    PassList.RemoveAt(index);
                    TempList.RemoveAt(COUNT + index);

                    SEAT_NAME = 0;
                    PRICE_ID = 0;
                    lblSeatName.Text = "Choose an available seat!";

                    LoadListView(PassList);
                    LoadSeats(TempList);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hành khách!");
            }
        }
        public void RemoveList()
        {
            IsRoundTrip = true;
            IsBackTrip = false;
            PassList1.Clear();
            PassList.Clear();
            LoadListView(PassList);
            LoadSeats(TempList);
            btnPayment.Text = "Next to back-trip";
            btnCancel.Text = "Cancel";
            lbText.Text = ID_FLIGHT + "'S SEATS --- FIRST TRIP";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(PassList.Count > 0)
            {
                if(TYPE == "ADMIN_ADD")
                {
                    if (IsRoundTrip)
                    {
                        lbText.Text = ID_FLIGHT1 + "'S SEATS --- RETURN TRIP";
                        btnPayment.Text = "Payment";
                        btnCancel.Text = "Back";
                        IsRoundTrip = false;
                        IsBackTrip = true;

                        SEAT_NAME = 0;
                        PRICE_ID = 0;
                        lblSeatName.Text = "Choose an available seat!";

                        LoadListView(PassList1);
                        LoadSeats(TempList1);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Xác nhận cập nhập dữ liệu hệ thống", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (IsBackTrip)
                            {
                                if(PassList1.Count > 0)
                                {
                                    foreach (TicketDTO i in PassList1)
                                    {
                                        TicketDAO.Instance.AddTicketToDataBase(i.fl_id, i.us_username, i.ticket_name, i.ticket_gender, i.ticket_mobile, i.ticket_address, i.seat_number, i.price_id);
                                    }
                                    PassList1.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng thêm hành khách!");
                                }
                                
                                //LoadListView(PassList1);
                            }
                            foreach (TicketDTO i in PassList)
                            {
                                TicketDAO.Instance.AddTicketToDataBase(i.fl_id, i.us_username, i.ticket_name, i.ticket_gender, i.ticket_mobile, i.ticket_address, i.seat_number, i.price_id);
                            }
                            IsBackTrip = false;
                            IsRoundTrip = true;
                            lbText.Text = ID_FLIGHT + "'S SEATS --- FIRST TRIP";
                            btnPayment.Text = "Next to back-trip";
                            btnCancel.Text = "Cancel";
                            SEAT_NAME = 0;
                            PRICE_ID = 0;
                            lblSeatName.Text = "Choose an available seat!";

                            PassList.Clear();
                            LoadListView(PassList);
                            LoadSeats(TempList);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do nothing
                        }
                    }
                    
                }
                else if(TYPE == "USER_ADD")
                {
                    if (IsRoundTrip)
                    {
                        lbText.Text = ID_FLIGHT1 + "'S SEATS --- RETURN TRIP";
                        btnPayment.Text = "Payment";
                        btnCancel.Text = "Back";
                        IsRoundTrip = false;
                        IsBackTrip = true;

                        SEAT_NAME = 0;
                        PRICE_ID = 0;
                        lblSeatName.Text = "Choose an available seat!";

                        LoadListView(PassList1);
                        LoadSeats(TempList1);
                    }
                    else
                    {
                        if (IsBackTrip)
                        {
                            if(PassList1.Count > 0)
                            {
                                SEAT_NAME = 0;
                                PRICE_ID = 0;
                                lblSeatName.Text = "Choose an available seat!";

                                PaymentForm f = new PaymentForm(PassList, USERNAME, PassList1);
                                f.remove += new PaymentForm.RemoveListCallback(RemoveList);
                                this.Hide();
                                f.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng thêm hành khách!");
                            }
                        }
                        else
                        {
                            SEAT_NAME = 0;
                            PRICE_ID = 0;
                            lblSeatName.Text = "Choose an available seat!";

                            PaymentForm f = new PaymentForm(PassList, USERNAME, PassList1);
                            f.remove += new PaymentForm.RemoveListCallback(RemoveList);
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        
                    }
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng thêm hành khách!");
            }
        }
    }
}
