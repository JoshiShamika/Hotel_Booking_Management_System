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
    public partial class UsersHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Page.IsPostBack==false) MessageBox.Show("Welcome " + LoginInfo.UserId);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}