using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_Exception;
using Group3_entity;
using Group3_Dal;
using Group3_BLL;


namespace HotelRegistration
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + LoginInfo.UserId);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            LoginInfo.UserId = "";
            this.Hide();
            log.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserProfile up = new UserProfile();
            up.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserHotelSearch uhs = new UserHotelSearch();
            uhs.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserBookings ub = new UserBookings();
            ub.Show();
        }
    }
}
