using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRegistration
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();

        }

        private void userRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReg ur = new UserReg();
            ur.Show();
        }

        private void hotelRegisterationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelReg hr = new HotelReg();
            hr.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
