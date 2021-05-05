using PBL3.DTO;
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
    public partial class UpdateForm : Form
    {
        private static string FLIGHT_ID;
        public delegate void ReloadCallBack(List<FlightDTO> list);
        public ReloadCallBack reload;
        public UpdateForm(string fl_id = null)
        {
            FLIGHT_ID = fl_id;
            InitializeComponent();
            LoadComboBox();
            FormInit();
        }
        public void FormInit()
        {
            if (FLIGHT_ID == null)
            {
                lbText.Text = "ADD A FLIGHT";
                cbbStatus.SelectedIndex = 0;
            }
            else
            {
                lbText.Text = "EDIT A FLIGHT";
                FlightDTO flight = FlightDAO.Instance.GetFlightByID(FLIGHT_ID);

                txbID.Enabled = false;
                txbID.Text = flight.fl_id;
                cbbAirline.SelectedIndex = AirlineDAO.Instance.GetAirlinePosition(flight.airline_id);
                cbbFrom.SelectedIndex = SourceDAO.Instance.GetSourceIndex(flight.fl_source);
                cbbTo.SelectedIndex = DestinationDAO.Instance.GetDestinationIndex(flight.fl_destination);
                dpkTakeoff.Value = flight.takeoff;
                dpkLanding.Value = flight.landing;
                numTakeoffHour.Value = flight.takeoff.Hour;
                numTakeoffMin.Value = flight.takeoff.Minute;
                numLandingHour.Value = flight.landing.Hour;
                numLandingMin.Value = flight.landing.Minute;
                txbDescrip.Text = flight.description;
                cbbStatus.SelectedIndex = flight.status;
                cbbTriptype.SelectedIndex = Convert.ToInt32(flight.triptype);

                if (flight.triptype)
                {
                    cbbRoundtrip.SelectedIndex = FlightDAO.Instance.GetIndexbyFlightID(flight.id_roundtrip);
                }
            }
        }
        public void LoadComboBox()
        {
            foreach (AirlineDTO i in AirlineDAO.Instance.AirlineList)
            {
                cbbAirline.Items.Add(new CBBItem(i.airline_id, i.airline_name));
            }
            foreach(FlightDTO i in FlightDAO.Instance.flightList)
            {
                cbbRoundtrip.Items.Add(i);

                cbbRoundtrip.DisplayMember = "fl_id";
            }

            foreach (SourceDTO i in SourceDAO.Instance.SourceList)
            {
                cbbFrom.Items.Add(new CBBItem(i.src_id, i.src_name));
            }
            foreach (DestinationDTO i in DestinationDAO.Instance.DestinationList)
            {
                cbbTo.Items.Add(new CBBItem(i.des_id, i.des_name));
            }
            List<CBBItem> listTrip = new List<CBBItem>()
            {
                new CBBItem(0, "One-Way"),
                new CBBItem(1, "Round-Trip")
            };
            List<CBBItem> listStatus = new List<CBBItem>()
            {
                new CBBItem(0, "Not yet take-off"),
                new CBBItem(1, "Arrived"),
                new CBBItem(2, "Cancel")
            };
            foreach (CBBItem i in listTrip)
            {
                cbbTriptype.Items.Add(i);
            }
            foreach (CBBItem i in listStatus)
            {
                cbbStatus.Items.Add(i);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "" || txbDescrip.Text == "" || cbbAirline.SelectedItem == null || cbbFrom.SelectedItem == null || cbbTo.SelectedItem == null || cbbTriptype.SelectedItem == null || cbbStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin chuyến bay!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Vui lòng xác nhận cập nhập dữ liệu!", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (FLIGHT_ID != null) //edit
                    {
                        FlightDTO fl = GetInput();
                        FlightDAO.Instance.EditFlighttoDatabase(fl);
                        reload(FlightDAO.Instance.flightList);
                        MessageBox.Show("Đã cập nhập chuyến bay thành công!");
                        Dispose();
                    }
                    else //add
                    {
                        FlightDTO fl = GetInput();
                        FlightDAO.Instance.AddFlighttoDatabase(fl);
                        reload(FlightDAO.Instance.flightList);
                        MessageBox.Show("Đã thêm chuyến bay thành công!");
                        Dispose();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }   
            }
        }
        public FlightDTO GetInput()
        {
            DateTime timeTakeoff = dpkTakeoff.Value;
            DateTime timeLanding = dpkLanding.Value;
            return new FlightDTO
            {
                fl_id = txbID.Text,
                airline_id = ((CBBItem)cbbAirline.SelectedItem).Value,
                fl_source = ((CBBItem)cbbFrom.SelectedItem).Value,
                fl_destination = ((CBBItem)cbbTo.SelectedItem).Value,
                takeoff = new DateTime(timeTakeoff.Year, timeTakeoff.Month, timeTakeoff.Day, (int)numTakeoffHour.Value, (int)numTakeoffMin.Value, timeTakeoff.Second),
                landing = new DateTime(timeLanding.Year, timeLanding.Month, timeLanding.Day, (int)numLandingHour.Value, (int)numLandingMin.Value, timeLanding.Second),
                triptype = Convert.ToBoolean(((CBBItem)cbbTriptype.SelectedItem).Value),
                description = txbDescrip.Text,
                status = ((CBBItem)cbbStatus.SelectedItem).Value,
                id_roundtrip = (Convert.ToBoolean(((CBBItem)cbbTriptype.SelectedItem).Value)) ? (((FlightDTO)cbbRoundtrip.SelectedItem).fl_id) : "",
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbbTriptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(((CBBItem)cbbTriptype.SelectedItem).Value))
            {
                cbbRoundtrip.Enabled = true;
                cbbRoundtrip.SelectedIndex = 0;
            }
            else
            {
                cbbRoundtrip.Enabled = false;
            }
        }
    }
}
