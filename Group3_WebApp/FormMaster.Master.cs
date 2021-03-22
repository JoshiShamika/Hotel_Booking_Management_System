using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group3_BLL;
using Group3_Dal;
using Group3_entity;
using Group3_Exception;
using System.Data.SqlClient;

namespace Group3_WebApp
{
    public partial class FormMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            LoginInfo.UserId = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}