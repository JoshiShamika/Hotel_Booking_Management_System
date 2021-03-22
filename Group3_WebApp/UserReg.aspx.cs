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
    public partial class UserReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Users newUser = new Users();
                if ((txt_Address.Text == "") || (txt_Email.Text == "") || (txt_Mobile.Text == "") || (txt_Password.Text == "") || (txt_Phone.Text == "") || (txt_UserId.Text == "") || (txt_UserName.Text == "") || (txt_UserRole.Text == ""))
                    throw new HMS_Exception("All fields must be entered");
                else
                {
                    newUser.Address = txt_Address.Text;
                    newUser.Email = txt_Email.Text;
                    newUser.MobileNo = txt_Mobile.Text;
                    newUser.Password = txt_Password.Text;
                    newUser.Phone = txt_Phone.Text;
                    newUser.Role = txt_UserRole.Text;
                    newUser.UserID = txt_UserId.Text;
                    newUser.UserName = txt_UserName.Text;

                    bool Useradded = HBMS_BLL.AddUserBL(newUser);
                    if (!Useradded) throw new HMS_Exception("User Cannot be added");
                    else MessageBox.Show("User Added Successfully");

                    Response.Redirect("LoginPage.aspx");
                   
                }
            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }

            finally
            {
                //LogIn log = new LogIn();
                //this.Hide();
                //log.Show();
               

            }
        }
    }
}