using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_BLL;
using Group3_Dal;
using Group3_entity;
using Group3_Exception;
using System.Data.SqlClient;
using System.IO;


namespace HotelRegistration
{
    public partial class RDetails : Form
    {
        public RDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try { 
            RoomDetails room = new RoomDetails();
            room.Availability =Convert.ToInt32(txt_Availability.Text);
            room.HotelID = txt_HotelID.Text;
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
                HomeView hh = new HomeView();
                this.Hide();
                hh.Show();
            }

            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }

            


        }

        private void RDetails_Load(object sender, EventArgs e)
        {
            txt_HotelID.Text = LoginInfo.UserId;
        }
    }
}
