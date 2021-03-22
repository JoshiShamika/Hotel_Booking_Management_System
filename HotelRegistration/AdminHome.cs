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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminUserList adminUser = new AdminUserList();
            adminUser.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminHotelList AdminHotel = new AdminHotelList();
            AdminHotel.Show();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            LoginInfo.UserId = "";
            log.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome "+LoginInfo.UserId);
        }
    }
}
