using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Group3_entity;

namespace Group3_WebApp
{
    public partial class HomeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) MessageBox.Show("Welcome " + LoginInfo.UserId);
        }
    }
}