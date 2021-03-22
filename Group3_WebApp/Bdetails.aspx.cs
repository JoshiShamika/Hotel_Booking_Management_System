using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group3_BLL;
using Group3_Dal;
using Group3_Exception;
using Group3_entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group3_WebApp
{
    public partial class Bdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_userID.Text = LoginInfo.UserId;
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_BookingDetails_Click(object sender, EventArgs e)
        {
            try
            {
                BookingDetails b = new BookingDetails();
                if (txt_Adult.Text == "" || txt_Amount.Text == "" || txt_BookingId.Text == "" || txt_Children.Text == "" || txt_RoomID.Text == "" || txt_userID.Text == "" || Calendar1.SelectedDate.Equals("") || Calendar2.SelectedDate.Equals(""))
                    throw new HMS_Exception("All data must be entered");
                else
                {
                    b.Amount = Convert.ToInt32(txt_Amount.Text);
                    b.BookedFrom = Calendar1.SelectedDate;
                    if (Calendar1.SelectedDate < System.DateTime.Now)
                        throw new HMS_Exception("Booked-from date should be greater than today's date!");
                    else
                        b.BookedTo = Calendar2.SelectedDate;
                    if (Calendar2.SelectedDate < Calendar1.SelectedDate)
                    {
                        throw new HMS_Exception("Booked-to date should be greater than booked-from date!");
                    }
                    else
                    {
                        b.BookingID = txt_BookingId.Text;

                    }
                    b.NoOfAdults = Convert.ToInt32(txt_Adult.Text);
                    b.NoOfChildren = Convert.ToInt32(txt_Children.Text);
                    b.RoomID = txt_RoomID.Text;
                    b.UserID = txt_userID.Text;

                    bool Bookadded = HBMS_BLL.AddBookingBL(b);
                    if (!Bookadded) throw new HMS_Exception("Booking Cannot be added");
                    else
                    {
                       lbl_show.Text="Booking Added Successfully";
                        Response.Redirect("UsersHome.aspx");
                    }
                }

            }
            catch (HMS_Exception ex)
            { lbl_show.Text=(ex.Message); }
            catch (SqlException e2)
            { lbl_show.Text = (e2.Message); }
            catch (Exception e1)
            {  lbl_show.Text=(e1.Message); }

        }
    }
}