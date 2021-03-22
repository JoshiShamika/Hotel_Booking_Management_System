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
    public partial class HotelReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel h1 = new Hotel();
                if (txt_Address.Text == "" || txt_AvgRatePerNight.Text == "" || txt_City.Text == "" || txt_Description.Text == "" || txt_Email.Text == "" || txt_Fax.Text == "" || txt_HotelID.Text == "" || txt_HotelName.Text == "" || txt_Phone1.Text == "" || txt_Phone2.Text == "" || txt_Rating.Text == "")
                    throw new HMS_Exception("All data must be entered");
                else { 
                h1.Address = txt_Address.Text;
                h1.AvgRatePerNight = Convert.ToInt32(txt_AvgRatePerNight.Text);
                h1.City = txt_City.Text;
                h1.Description = txt_Description.Text;
                h1.Email = txt_Email.Text;
                h1.Fax = txt_Fax.Text;
                h1.HotelID = txt_HotelID.Text;
                h1.HotelName = txt_HotelName.Text;
                h1.PhoneNo1 = txt_Phone1.Text;
                h1.PhoneNo2 = txt_Phone2.Text;
                h1.Rating = txt_Rating.Text;



                bool Hoteladded = HBMS_BLL.AddHotelBL(h1);
                if (!Hoteladded)
                {
                    throw new HMS_Exception("Hotel Cannot be added");


                }
                else
                {
                   MessageBox.Show("Hotel Added Successfully");
                    Response.Redirect("LoginPage.aspx");
                }

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