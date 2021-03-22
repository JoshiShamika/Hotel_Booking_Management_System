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
    public partial class AdminUserList : Form
    {
        public AdminUserList()
        {
            InitializeComponent();
        }

        private void AdminUserList_Load(object sender, EventArgs e)
        {
            try { Dgv_UserList.DataSource = HBMS_BLL.DisplayAllUserBL(); }
            catch (HMS_Exception p)
            {
                MessageBox.Show("No records Found!");
            }
            
        }
    }
}
