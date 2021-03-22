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
    public partial class HotelReg : Form
    {
        public HotelReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel h1 = new Hotel();
                h1.Address = txt_Address.Text;
                h1.AvgRatePerNight = Convert.ToInt32(txt_AvgRate.Text);
                h1.City = txt_City.Text;
                h1.Description = txt_Description.Text;
                h1.Email = txt_Email.Text;
                h1.Fax = txt_Fax.Text;
                h1.HotelID = txt_HotelId.Text;
                h1.HotelName = txt_HotelName.Text;
                h1.PhoneNo1 = txt_PhoneNo1.Text;
                h1.PhoneNo2 = txt_PhoneNo2.Text;
                h1.Rating = txt_Rating.Text;



                bool Hoteladded = HBMS_BLL.AddHotelBL(h1);
                if (!Hoteladded)
                {
                    throw new HMS_Exception("Hotel Cannot be added");
                    

                }
                else
                {
                    MessageBox.Show("Hotel Added Successfully");
                   
                }

            }
            catch (HMS_Exception ex)
            { MessageBox.Show(ex.Message); }
            catch (SqlException e2)
            { MessageBox.Show(e2.Message); }
            catch (Exception e1)
            { MessageBox.Show(e1.Message); }

            finally {
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
    }
}
