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

namespace Group3_WebApp
{
    public partial class HotelViewRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<RoomDetails> hlist = new List<RoomDetails>();
                hlist = HBMS_BLL.FilteredRoomBL(LoginInfo.UserId);
                grd_ViewRoom.DataSource = hlist;
                grd_ViewRoom.DataBind();


                //gdv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); 
            }
            catch (HMS_Exception p)
            {
                Response.Write("No records Found!");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }

        protected void grd_ViewRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            //    try
            //    {
            //        List<RoomDetails> hlist = new List<RoomDetails>();
            //        hlist = HBMS_BLL.FilteredRoomBL(LoginInfo.UserId);
            //        grd_ViewRoom.DataSource = hlist;
            //        grd_ViewRoom.DataBind();


            //        //gdv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); 
            //    }
            //    catch (HMS_Exception p)
            //    {
            //        Response.Write("No records Found!");
            //    }

            //}
        }
    }
}