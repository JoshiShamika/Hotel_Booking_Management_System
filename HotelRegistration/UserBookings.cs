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

namespace HotelRegistration
{
    public partial class UserBookings : Form
    {
        public UserBookings()
        {
            InitializeComponent();
        }

        private void UserBookings_Load(object sender, EventArgs e)
        {
            try { 
            dgv_bookingHistory.DataSource = HBMS_BLL.FilteredBookingBL(LoginInfo.UserId);
                }
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
        }

        private void dgv_bookingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
