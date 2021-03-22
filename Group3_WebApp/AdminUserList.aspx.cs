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
    public partial class AdminUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Users> hlist = new List<Users>();
                hlist = HBMS_BLL.DisplayAllUserBL();
                gdv_userList.DataSource = hlist;
                gdv_userList.DataBind();


                //gdv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); 
            }
            catch (HMS_Exception p)
            {
                Response.Write("No records Found!");
            }
        }

        protected void gdv_userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}