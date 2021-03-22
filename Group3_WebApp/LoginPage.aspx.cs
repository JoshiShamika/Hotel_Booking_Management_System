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


namespace Group3_WebApp
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddl_usertype.SelectedItem.Text.Equals("Admin"))
                {
                    Admin newAdmin = new Admin();
                    newAdmin.AdminUserName = txt_userName.Text;
                    newAdmin.AdminPwd = txt_password.Text;
                    bool Useradded = HBMS_BLL.AdminLoginBL(newAdmin);
                    if (!Useradded) throw new HMS_Exception("Login Unsuccessfully");
                    else
                    {
                        lbl_Show.Text="Login Successfully";
                        LoginInfo.UserId = txt_userName.Text;
                        Response.Redirect("AdminHome.aspx");
                       // AdminHome ah = new AdminHome();
                        //this.Hide();
                        //ah.Show();
                    }

                }
                else if (ddl_usertype.SelectedItem.Text.Equals("User"))
                {

                    User usr = new User();
                    usr.UserID = txt_userName.Text;
                    usr.UserPassWord = txt_password.Text;
                    bool UserLogin = HBMS_BLL.UserLoginBL(usr);
                    if (!UserLogin) throw new HMS_Exception("Login Unsuccessfully");
                    else
                    {
                        lbl_Show.Text = "Login Successfully";
                        LoginInfo.UserId = txt_userName.Text;
                        Response.Redirect("UsersHome.aspx");
                       
                    }

                }
                else if (ddl_usertype.SelectedItem.Text.Equals("Hotel"))
                {
                    Hotel htl = new Hotel();
                    htl.HotelID = txt_userName.Text;
                    htl.HotelName = txt_password.Text;
                    bool HotelLogin = HBMS_BLL.HotelLoginBL(htl);
                    if (!HotelLogin) throw new HMS_Exception("Login Unsuccessfully");
                    else
                    {
                        lbl_Show.Text = "Login Successfully";
                        LoginInfo.UserId = txt_userName.Text;
                        Response.Redirect("HomeView.aspx");
                      //  HomeView Hh = new HomeView();
                        //this.Hide();
                       // Hh.Show();
                    }

                }
            }
            catch (HMS_Exception ex)
            { lbl_Show.Text=(ex.Message); }
            catch (SqlException e2)
            { lbl_Show.Text=(e2.Message); }
            catch (Exception e1)
            { lbl_Show.Text=(e1.Message); }
        }

        protected void ddl_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            txt_userName.Text = string.Empty;
            txt_password.Text = string.Empty;
            //ddl_usertype.SelectedIndex=
        }
    }
}