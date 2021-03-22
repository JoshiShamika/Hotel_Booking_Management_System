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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HotelViewRoom hvr = new HotelViewRoom();
            hvr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RDetails room = new RDetails();
            //this.Hide();
            room.Show();
        }

        private void HomeView_Load(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {
            HotelProfile hp = new HotelProfile();
            hp.Show();
        }
    }
}
