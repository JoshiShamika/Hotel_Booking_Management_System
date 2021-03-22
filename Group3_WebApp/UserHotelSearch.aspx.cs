using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group3_entity;
using Group3_Exception;
using Group3_Dal;
using Group3_BLL;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Group3_WebApp
{
    public partial class UserHotelSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                List<Hotel> hlist = new List<Hotel>();
                hlist = HBMS_BLL.SearchAllHotelBL(txt_search.Text);
                grd_HotelSearch.DataSource = hlist;
                grd_HotelSearch.DataBind();


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

        protected void grd_HotelSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}