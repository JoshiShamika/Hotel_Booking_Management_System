using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_Dal;
using Group3_BLL;
using Group3_entity;
using Group3_Exception;
using System.Data.SqlClient;

namespace HotelRegistration
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Users newUser = new Users();
                newUser.Address = txt_addr.Text;
                newUser.Email = txt_email.Text;
                newUser.MobileNo = txt_MobNo.Text;
                newUser.Password = txt_Pwd.Text;
                newUser.Phone = txt_PhoneNo.Text;
                newUser.Role = txt_Role.Text;
                newUser.UserID = txt_UserID.Text;
                newUser.UserName = txt_UserName.Text;

                bool Useradded = HBMS_BLL.AddUserBL(newUser);
                if (!Useradded) throw new HMS_Exception("User Cannot be added");
                else MessageBox.Show("User Added Successfully");

            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }

            finally
            {
                LogIn log = new LogIn();
                this.Hide();
                log.Show();

            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
