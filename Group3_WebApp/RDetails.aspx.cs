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
    public partial class RDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_HotelId.Text = LoginInfo.UserId;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
              try { 

            RoomDetails room = new RoomDetails();
            if (txt_Availability.Text == "" || txt_HotelId.Text == "" || txt_PerNightRate.Text == "" || txt_RoomId.Text == "" || txt_RoomNo.Text == "" || txt_RoomType.Text == "")
                throw new HMS_Exception("All data must be entered");
            else
            { 
            room.Availability =Convert.ToInt32(txt_Availability.Text);
            room.HotelID = txt_HotelId.Text;
            room.PerNightrate = Convert.ToInt32(txt_PerNightRate.Text);
            //room.photo = openFileDialog1.FileName;
            room.RoomID = txt_RoomId.Text;
            room.RoomNo = txt_RoomNo.Text;
            room.RoomType = txt_RoomType.Text;
            bool Roomadded = HBMS_BLL.AddRoomBL(room);
            if (!Roomadded) throw new HMS_Exception("Room Cannot be added");
            else
            {
                MessageBox.Show("Room Added Successfully");
                //HomeView hh = new HomeView();
                Response.Redirect("HomeView.aspx");
            }
            }

            }
            catch (HMS_Exception ex)
              { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
              { MessageBox.Show(e2.Message); }
            catch (Exception e1)
              { MessageBox.Show(e1.Message); }

            


        }
        }
    }
