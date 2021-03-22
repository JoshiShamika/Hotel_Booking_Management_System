using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_Exception;
using Group3_entity;
using Group3_Dal;
using Group3_BLL;
using System.Data.SqlClient;

namespace HotelRegistration
{
    public partial class Bdetails : Form
    {
        public Bdetails()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try { 
            BookingDetails b = new BookingDetails();
            b.Amount = Convert.ToInt32(txt_Amt.Text);
            b.BookedFrom = DTP_BookedFrom.Value;
            if(DTP_BookedFrom.Value<System.DateTime.Now)
                throw new HMS_Exception("Booked-from date should be greater than today's date!");
            else
                b.BookedTo = DTP_bookedTo.Value;
            if (DTP_bookedTo.Value < DTP_BookedFrom.Value)
            {
                throw new HMS_Exception("Booked-to date should be greater than booked-from date!");
            }
            else {
                b.BookingID = txt_BookingId.Text;
               
            }
            b.NoOfAdults = Convert.ToInt32(txt_NoOfAdults.Text);
            b.NoOfChildren = Convert.ToInt32(txt_NoOfChildren.Text);
            b.RoomID = txt_RoomId.Text;
            b.UserID = txt_UserId.Text;

            bool Bookadded = HBMS_BLL.AddBookingBL(b);
            if (!Bookadded) throw new HMS_Exception("Booking Cannot be added");
            else
            {
                MessageBox.Show("Booking Added Successfully");
                UserHome uh = new UserHome();
                this.Hide();
                uh.Show();
            }

            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }

            
        }

        private void Bdetails_Load(object sender, EventArgs e)
        {
            txt_UserId.Text = LoginInfo.UserId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
