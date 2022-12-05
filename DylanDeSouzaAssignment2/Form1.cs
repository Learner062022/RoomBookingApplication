using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DylanDeSouzaAssignment2
{
    public partial class FrmRoomBookingApplicationWestCoastHotel : Form
    {
        public FrmRoomBookingApplicationWestCoastHotel()
        {
            InitializeComponent();
            toolTip1.SetToolTip(txt_room_num, "Enter a number");
            toolTip1.SetToolTip(txt_customer_name, "Enter a name");
            toolTip1.SetToolTip(txt_duration_stay, "Enter a number");
            toolTip1.SetToolTip(txt_room_size, "Enter the room's size");
        }

        const int DAILY_RATE_SINGLE = 80, DAILY_RATE_DBLE = 110, DAILY_RATE_TRIPLE = 140;

        struct booking_info
        {
            public string name, room_size;
            public int room_num, duration_stay, charge;
        }

        List<booking_info> bookings = new List<booking_info>();

        booking_info booking_details;
        int int_charge, int_room_num, int_num_days;
        string str_room_size, str_name;

        private void btn_display_bookings_Click(object sender, EventArgs e)
        {
            string str_type_room, str_cus_name;
            int int_num_room, int_cost, int_days;

            lst_bookings.Items.Clear();
            lst_bookings.Items.Add("Name\tRoom No\tNum Days\tRoom Size\tCharge");

            if (txt_room_size.Text == "")
            {
                errorProvider4.SetError(txt_room_size, "The room's size wasn't entered");
                txt_room_size.Focus();
            }
            else if (txt_room_size.Text != "")
            {
                if (txt_room_size.Text != txt_room_size.Text.ToLower() || txt_room_size.Text != txt_room_size.Text.ToUpper())
                {
                    errorProvider4.SetError(txt_room_size, "The room's size must be in uppercases or lowercases");
                    txt_room_size.Clear();
                    txt_room_size.Focus();
                }
                else
                {             
                    errorProvider4.Dispose();

                    foreach (booking_info booking_details in bookings)
                    {
                        str_type_room = booking_details.room_size;
                        str_cus_name = booking_details.name;
                        int_num_room = booking_details.room_num;
                        int_days = booking_details.duration_stay;
                        int_cost = booking_details.charge;

                        lst_bookings.Items.Add(str_cus_name + "\t" + int_num_room + "\t" + int_days + "\t" + str_type_room + "\t" + int_cost);
                    }
                }
            }
        }

        private void btn_confirm_booking_Click(object sender, EventArgs e)
        {
            if (rdo_single.Checked)
            {
                lst_bookings.Items[0] = "Customers in " + rdo_single.Text + " Rooms";
                int_charge = DAILY_RATE_SINGLE * int_num_days;
                str_room_size = rdo_single.Text;
            }

            if (rdo_dble.Checked)
            {
                lst_bookings.Items[0] = "Customers in " + rdo_dble.Text + " Rooms";
                int_charge = DAILY_RATE_DBLE * int_num_days;
                str_room_size = rdo_dble.Text;
            }

            if (rdo_triple.Checked)
            {
                lst_bookings.Items[0] = "Customers in " + rdo_triple.Text + " Rooms";
                int_charge = DAILY_RATE_TRIPLE * int_num_days;
                str_room_size = rdo_triple.Text;
            }

            if (bookings.Count == 150)
            {
                MessageBox.Show("No more bookings are available");
            }

            if (txt_customer_name.Text == "")
            {
                errorProvider1.SetError(txt_customer_name, "The textbox cannot be blank");
                txt_customer_name.Focus();
            }
            else
            {
                errorProvider1.Dispose();
                str_name = txt_customer_name.Text;
                booking_details.name = str_name;
                txt_customer_name.Clear();
                txt_customer_name.Focus();
            }

            if (!int.TryParse(txt_duration_stay.Text, out int_num_days))
            {
                errorProvider2.SetError(txt_duration_stay, int_num_days + " is not a number");
            }

            try
            {
                int_room_num = int.Parse(txt_room_num.Text);
                booking_details.room_num = int_room_num;
                txt_room_num.Clear();
                errorProvider3.Dispose();
            }
            catch (Exception ex)
            {
                errorProvider3.SetError(txt_room_num, ex.ToString());
            }
            finally
            {
                txt_room_num.Clear();
                txt_room_num.Focus();
            }

            try
            {
                int_num_days = int.Parse(txt_duration_stay.Text);
                booking_details.duration_stay = int_num_days;
                txt_duration_stay.Clear();
                errorProvider2.Dispose();
            }
            catch (Exception ex)
            {
                errorProvider2.SetError(txt_duration_stay, ex.ToString());
            }
            finally
            {
                txt_duration_stay.Clear();
                txt_duration_stay.Focus();
            }

            booking_details.charge = int_charge;
            booking_details.room_size = str_room_size;
            bookings.Add(booking_details);

            lst_bookings.Items.Add(booking_details.name + "\t" + booking_details.room_num);
        }
    }
}
