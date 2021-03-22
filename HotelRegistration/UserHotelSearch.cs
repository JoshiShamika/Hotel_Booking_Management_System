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
    public partial class UserHotelSearch : Form
    {
        public UserHotelSearch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Bdetails book = new Bdetails();
            book.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try { 
            dgv_SearchHotel.DataSource = HBMS_BLL.SearchAllHotelBL(txt_searchCity.Text);
                }
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
            
        }

        private void UserHotelSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
