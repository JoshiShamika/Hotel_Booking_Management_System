using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group3_entity;
using Group3_Exception;
using Group3_Dal;
using Group3_BLL;
using System.Data.SqlClient;
namespace Group3_WebApp
{
    public partial class UserBookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

               try
            {
                List<BookingDetails> hlist = new List<BookingDetails>();
                hlist = HBMS_BLL.FilteredBookingBL(LoginInfo.UserId);
                grd_userBookings.DataSource = hlist;
                grd_userBookings.DataBind();


                //gdv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); 
            }


                //gdv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); 
            
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
        }

        protected void grd_userBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}