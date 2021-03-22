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
    public partial class HotelViewRoom : Form
    {
        public HotelViewRoom()
        {
            InitializeComponent();
        }

        private void HotelViewRoom_Load(object sender, EventArgs e)
        {
            try { dgv_RoomDetails.DataSource = HBMS_BLL.FilteredRoomBL(LoginInfo.UserId); }
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
        }

        private void dgv_RoomDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
