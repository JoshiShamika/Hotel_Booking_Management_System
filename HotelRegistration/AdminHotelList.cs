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
    public partial class AdminHotelList : Form
    {
        public AdminHotelList()
        {
            InitializeComponent();
        }

        private void AdminHotelList_Load(object sender, EventArgs e)
        {
            try { Dgv_HotelList.DataSource = HBMS_BLL.DisplayAllHotelBL(); }
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
        }

        private void Dgv_HotelList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
