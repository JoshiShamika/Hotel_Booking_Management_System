using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group3_entity;
using Group3_Exception;
using Group3_Dal;
using Group3_BLL;
using System.Data.SqlClient;

namespace HotelRegistration
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HotelReg hotelR = new HotelReg();
            this.Hide();
            hotelR.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserReg userR = new UserReg();
            this.Hide();
            userR.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

           
            try{
            if (comboBox1.SelectedItem.Equals("Admin"))
            {
                Admin newAdmin = new Admin();
                newAdmin.AdminUserName = txt_UserName.Text;
                newAdmin.AdminPwd = txt_Password.Text;
                bool Useradded = HBMS_BLL.AdminLoginBL(newAdmin);
                if (!Useradded) throw new HMS_Exception("Login Unsuccessfully");
                else 
                {
                    MessageBox.Show("Login Successfully");
                    LoginInfo.UserId = txt_UserName.Text;
                    AdminHome ah=new AdminHome();
                    this.Hide();
                    ah.Show();
                }

            }
            else if (comboBox1.SelectedItem.Equals("User"))
            {

                User usr = new User();
                usr.UserID = txt_UserName.Text;
                usr.UserPassWord = txt_Password.Text;
                bool UserLogin = HBMS_BLL.UserLoginBL(usr);
                if (!UserLogin) throw new HMS_Exception("Login Unsuccessfully");
                else
                {
                    MessageBox.Show("Login Successfully");
                    LoginInfo.UserId = txt_UserName.Text;
                    UserHome Uh = new UserHome();
                    this.Hide();
                    Uh.Show();
                }

            }
            else if (comboBox1.SelectedItem.Equals("Hotel"))
            {
                Hotel htl = new Hotel();
                htl.HotelID = txt_UserName.Text;
                htl.HotelName = txt_Password.Text;
                bool HotelLogin = HBMS_BLL.HotelLoginBL(htl);
                if (!HotelLogin) throw new HMS_Exception("Login Unsuccessfully");
                else
                {
                    MessageBox.Show("Login Successfully");
                    LoginInfo.UserId = txt_UserName.Text;
                    HomeView Hh = new HomeView();
                    this.Hide();
                    Hh.Show();
                }

            }
            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }
            }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
