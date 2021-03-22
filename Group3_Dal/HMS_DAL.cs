using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Group3_entity;
using Group3_Exception;
using System.Configuration;

namespace Group3_Dal
{
    public class HMS_DAL
    {

         static  SqlConnection conTraining;


        /// <summary>
        /// Purpose:Constructor to establish the connection
        /// </summary>
         static HMS_DAL()
    {
     conTraining = new SqlConnection();
     conTraining.ConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
     }



        /// <summary>
        /// Purpose:Dal function to add data to Hotels to database
        /// </summary>
        /// <param name="newHotel"></param>
        /// <returns></returns>
         public static bool AddHotelDAL(Hotel newHotel)
         {
             bool HotelAdded = false;
             try
             {
                 SqlCommand cmdAddHotel = new SqlCommand();
                 cmdAddHotel.Connection = conTraining;
                 cmdAddHotel.CommandType = CommandType.StoredProcedure;
                 cmdAddHotel.CommandText = "GROUP3.USP_InsertHotel";
                 conTraining.Open();
                 SqlParameter[] paramHotel = new SqlParameter[11];

                 paramHotel[0] = new SqlParameter("@hotel_id", SqlDbType.NVarChar, 4);
                 paramHotel[0].Direction = ParameterDirection.Input;
                 paramHotel[0].Value = newHotel.HotelID;
                 cmdAddHotel.Parameters.Add(paramHotel[0]);

                 paramHotel[1] = new SqlParameter("@city", SqlDbType.NVarChar, 10);
                 paramHotel[1].Direction = ParameterDirection.Input;
                 paramHotel[1].Value = newHotel.City;
                 cmdAddHotel.Parameters.Add(paramHotel[1]);

                 paramHotel[2] = new SqlParameter("@hotel_name", SqlDbType.NVarChar, 20);
                 paramHotel[2].Direction = ParameterDirection.Input;
                 paramHotel[2].Value = newHotel.HotelName;
                 cmdAddHotel.Parameters.Add(paramHotel[2]);

                 paramHotel[3] = new SqlParameter("@HotelAddress", SqlDbType.NVarChar, 25);
                 paramHotel[3].Direction = ParameterDirection.Input;
                 paramHotel[3].Value = newHotel.Address;
                 cmdAddHotel.Parameters.Add(paramHotel[3]);

                 paramHotel[4] = new SqlParameter("@HotelDescription", SqlDbType.NVarChar, 50);
                 paramHotel[4].Direction = ParameterDirection.Input;
                 paramHotel[4].Value = newHotel.Description;
                 cmdAddHotel.Parameters.Add(paramHotel[4]);

                 paramHotel[5] = new SqlParameter("@avg_rate_per_night", SqlDbType.Int);
                 paramHotel[5].Direction = ParameterDirection.Input;
                 paramHotel[5].Value = newHotel.AvgRatePerNight;
                 cmdAddHotel.Parameters.Add(paramHotel[5]);

                 paramHotel[6] = new SqlParameter("@phone_no1", SqlDbType.NVarChar, 10);
                 paramHotel[6].Direction = ParameterDirection.Input;
                 paramHotel[6].Value = newHotel.PhoneNo1;
                 cmdAddHotel.Parameters.Add(paramHotel[6]);

                 paramHotel[7] = new SqlParameter("@phone_no2", SqlDbType.NVarChar, 10);
                 paramHotel[7].Direction = ParameterDirection.Input;
                 paramHotel[7].Value = newHotel.PhoneNo2;
                 cmdAddHotel.Parameters.Add(paramHotel[7]);

                 paramHotel[8] = new SqlParameter("@rating", SqlDbType.NVarChar, 4);
                 paramHotel[8].Direction = ParameterDirection.Input;
                 paramHotel[8].Value = newHotel.Rating;
                 cmdAddHotel.Parameters.Add(paramHotel[8]);

                 paramHotel[9] = new SqlParameter("@email", SqlDbType.NVarChar, 15);
                 paramHotel[9].Direction = ParameterDirection.Input;
                 paramHotel[9].Value = newHotel.Email;
                 cmdAddHotel.Parameters.Add(paramHotel[9]);

                 paramHotel[10] = new SqlParameter("@fax", SqlDbType.NVarChar, 15);
                 paramHotel[10].Direction = ParameterDirection.Input;
                 paramHotel[10].Value = newHotel.Fax;
                 cmdAddHotel.Parameters.Add(paramHotel[10]);


                 int affectedRows = cmdAddHotel.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     HotelAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return HotelAdded;

         }



        /// <summary>
        /// Purpose:Dal function to Display the List of hotel
        /// </summary>
        /// <returns></returns>
         public static List<Hotel> ShowAllHotelDAL()
         {
             List<Hotel> HotelList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdshowHotel = conTraining.CreateCommand();
                 cmdshowHotel.CommandText = "GROUP3.USP_DisplayHotel";

                 SqlDataReader readerHotel = null;
                 readerHotel = cmdshowHotel.ExecuteReader();

                 DataTable HotelTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 HotelTable.Load(readerHotel);
                 if (HotelTable.Rows.Count > 0)
                 {
                     HotelList = new List<Hotel>();
                     foreach (DataRow row in HotelTable.Rows)
                     {
                         Hotel Hotel1 = new Hotel();

                         Hotel1.HotelID = (string)(row[0]);
                         Hotel1.City = (string)(row[1]);
                         Hotel1.HotelName = (string)(row[2]);
                         Hotel1.Address = (string)(row[3]);
                         Hotel1.Description = (string)(row[4]);
                         Hotel1.AvgRatePerNight = (int)(row[5]);
                         Hotel1.PhoneNo1 = (string)(row[6]);
                         Hotel1.PhoneNo2 = (string)(row[7]);
                         Hotel1.Rating = (string)(row[8]);
                         Hotel1.Email = (string)(row[9]);
                         Hotel1.Fax = (string)(row[10]);

                         HotelList.Add(Hotel1);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return HotelList;
         }


        /// <summary>
        /// Purpose:Dal function for adding users to database
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
         public static bool AddUserDAL(Users newUser)
         {
             bool UserAdded = false;
             try
             {
                 SqlCommand cmdAddUser = new SqlCommand();
                 cmdAddUser.Connection = conTraining;
                 cmdAddUser.CommandType = CommandType.StoredProcedure;
                 cmdAddUser.CommandText = "GROUP3.USP_InsertUsers";
                 conTraining.Open();
                 SqlParameter[] paramUser = new SqlParameter[8];

                 paramUser[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 4);
                 paramUser[0].Direction = ParameterDirection.Input;
                 paramUser[0].Value = newUser.UserID;
                 cmdAddUser.Parameters.Add(paramUser[0]);

                 paramUser[1] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 7);
                 paramUser[1].Direction = ParameterDirection.Input;
                 paramUser[1].Value = newUser.Password;
                 cmdAddUser.Parameters.Add(paramUser[1]);

                 paramUser[2] = new SqlParameter("@UserRole", SqlDbType.NVarChar, 7);
                 paramUser[2].Direction = ParameterDirection.Input;
                 paramUser[2].Value = newUser.Role;
                 cmdAddUser.Parameters.Add(paramUser[2]);

                 paramUser[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 7);
                 paramUser[3].Direction = ParameterDirection.Input;
                 paramUser[3].Value = newUser.UserName;
                 cmdAddUser.Parameters.Add(paramUser[3]);

                 paramUser[4] = new SqlParameter("@Mobile_no", SqlDbType.NVarChar, 7);
                 paramUser[4].Direction = ParameterDirection.Input;
                 paramUser[4].Value = newUser.MobileNo;
                 cmdAddUser.Parameters.Add(paramUser[4]);

                 paramUser[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 7);
                 paramUser[5].Direction = ParameterDirection.Input;
                 paramUser[5].Value = newUser.Phone;
                 cmdAddUser.Parameters.Add(paramUser[5]);

                 paramUser[6] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, 7);
                 paramUser[6].Direction = ParameterDirection.Input;
                 paramUser[6].Value = newUser.Address;
                 cmdAddUser.Parameters.Add(paramUser[6]);

                 paramUser[7] = new SqlParameter("@email", SqlDbType.NVarChar, 7);
                 paramUser[7].Direction = ParameterDirection.Input;
                 paramUser[7].Value = newUser.Email;
                 cmdAddUser.Parameters.Add(paramUser[7]);


                 int affectedRows = cmdAddUser.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     UserAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return UserAdded;

         }


         /// <summary>
         /// Purpose:Dal function to display users
         /// </summary>
         /// <returns></returns>
         public static List<Users> ShowAllUsersDAL()
         {
             List<Users> UserList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdshowUser = conTraining.CreateCommand();
                 cmdshowUser.CommandText = "GROUP3.USP_DisplayUsers";

                 SqlDataReader readerUser = null;
                 readerUser = cmdshowUser.ExecuteReader();

                 DataTable UserTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 UserTable.Load(readerUser);
                 if (UserTable.Rows.Count > 0)
                 {
                     UserList = new List<Users>();
                     foreach (DataRow row in UserTable.Rows)
                     {
                         Users User = new Users();

                         User.UserID = (string)(row[0]);
                         User.Password = (string)(row[1]);
                         User.Role = (string)(row[2]);
                         User.UserName = (string)(row[3]);
                         User.MobileNo = (string)(row[4]);
                         User.Phone = (string)(row[5]);
                         User.Address = (string)(row[6]);
                         User.Email = (string)(row[7]);
                         UserList.Add(User);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return UserList;
         }


        /// <summary>
        /// Purpose:DAL login for admin
        /// </summary>
        /// <param name="Newlogin"></param>
        /// <returns></returns>
         public static bool AdminLoginDetailsDAL(Admin Newlogin)
         {
             bool LoginAdded = false;
             try
             {
                 SqlCommand cmdAddLogin = new SqlCommand();
                 cmdAddLogin.Connection = conTraining;
                 cmdAddLogin.CommandType = CommandType.StoredProcedure;
                 cmdAddLogin.CommandText = "[GROUP3].[USP_LoginAdmin]";
                 conTraining.Open();
                 SqlParameter[] paramAdminLogin = new SqlParameter[2];

                 paramAdminLogin[0] = new SqlParameter("@AdminUserName", SqlDbType.NVarChar, 20);
                 paramAdminLogin[0].Direction = ParameterDirection.Input;
                 paramAdminLogin[0].Value = Newlogin.AdminUserName;
                 cmdAddLogin.Parameters.Add(paramAdminLogin[0]);

                 paramAdminLogin[1] = new SqlParameter("@AdminPwd", SqlDbType.NVarChar, 20);
                 paramAdminLogin[1].Direction = ParameterDirection.Input;
                 paramAdminLogin[1].Value = Newlogin.AdminPwd;
                 cmdAddLogin.Parameters.Add(paramAdminLogin[1]);



                 SqlDataReader readerAdmin = null;
                 readerAdmin = cmdAddLogin.ExecuteReader();

                 DataTable UserTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 UserTable.Load(readerAdmin);
                 if (UserTable.Rows.Count > 0)
                 {
                     LoginAdded = true;  
                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return LoginAdded;

         }

         /// <summary>
         /// Purpose:Dal login for User
         /// </summary>
         /// <param name="Newlogin"></param>
         /// <returns></returns>
         public static bool UserLoginDetailsDAL(User Newlogin)
         {
             bool LoginAdded = false;
             try
             {
                 SqlCommand cmdAddLogin = new SqlCommand();
                 cmdAddLogin.Connection = conTraining;
                 cmdAddLogin.CommandType = CommandType.StoredProcedure;
                 cmdAddLogin.CommandText = "[GROUP3].[USP_LoginUsers]";
                 conTraining.Open();
                 SqlParameter[] paramUserLogin = new SqlParameter[2];

                 paramUserLogin[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 4);
                 paramUserLogin[0].Direction = ParameterDirection.Input;
                 paramUserLogin[0].Value = Newlogin.UserID;
                 cmdAddLogin.Parameters.Add(paramUserLogin[0]);

                 paramUserLogin[1] = new SqlParameter("@Userpwd", SqlDbType.NVarChar, 7);
                 paramUserLogin[1].Direction = ParameterDirection.Input;
                 paramUserLogin[1].Value = Newlogin.UserPassWord;
                 cmdAddLogin.Parameters.Add(paramUserLogin[1]);



                 SqlDataReader readerAdmin = null;
                 readerAdmin = cmdAddLogin.ExecuteReader();

                 DataTable UserTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 UserTable.Load(readerAdmin);
                 if (UserTable.Rows.Count > 0)
                 {
                     LoginAdded = true;
                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return LoginAdded;

         }


        /// <summary>
        /// Purpose:dal login for hotels
        /// </summary>
        /// <param name="NewHotel"></param>
        /// <returns></returns>
         public static bool HotelLoginDetailsDAL(Hotel NewHotel)
         {
             bool LoginAdded = false;
             try
             {
                 SqlCommand cmdAddLogin = new SqlCommand();
                 cmdAddLogin.Connection = conTraining;
                 cmdAddLogin.CommandType = CommandType.StoredProcedure;
                 cmdAddLogin.CommandText = "[GROUP3].[USP_LoginHotel]";
                 conTraining.Open();
                 SqlParameter[] paramHotelLogin = new SqlParameter[2];

                 paramHotelLogin[0] = new SqlParameter("@HotelID", SqlDbType.NVarChar, 4);
                 paramHotelLogin[0].Direction = ParameterDirection.Input;
                 paramHotelLogin[0].Value = NewHotel.HotelID;
                 cmdAddLogin.Parameters.Add(paramHotelLogin[0]);

                 paramHotelLogin[1] = new SqlParameter("@HotelName", SqlDbType.NVarChar, 20);
                 paramHotelLogin[1].Direction = ParameterDirection.Input;
                 paramHotelLogin[1].Value = NewHotel.HotelName;
                 cmdAddLogin.Parameters.Add(paramHotelLogin[1]);



                 SqlDataReader readerAdmin = null;
                 readerAdmin = cmdAddLogin.ExecuteReader();

                 DataTable UserTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 UserTable.Load(readerAdmin);
                 if (UserTable.Rows.Count > 0)
                 {
                     LoginAdded = true;
                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return LoginAdded;

         }



         /// <summary>
         /// Purpose:Dal function to add the booking details to booking details table
         /// </summary>
         /// <param name="newBooking"></param>
         /// <returns></returns>
         public static bool AddBookingDetailsDAL(BookingDetails newBooking)
         {
             bool BookingAdded = false;
             try
             {
                 SqlCommand cmdAddBooking = new SqlCommand();
                 cmdAddBooking.Connection = conTraining;
                 cmdAddBooking.CommandType = CommandType.StoredProcedure;
                 cmdAddBooking.CommandText = "GROUP3.USP_InsertBookingDetails";
                 conTraining.Open();
                 SqlParameter[] paramBooking = new SqlParameter[8];

                 paramBooking[0] = new SqlParameter("@booking_id", SqlDbType.NVarChar, 4);
                 paramBooking[0].Direction = ParameterDirection.Input;
                 paramBooking[0].Value = newBooking.BookingID;
                 cmdAddBooking.Parameters.Add(paramBooking[0]);

                 paramBooking[1] = new SqlParameter("@room_id", SqlDbType.NVarChar, 4);
                 paramBooking[1].Direction = ParameterDirection.Input;
                 paramBooking[1].Value = newBooking.RoomID;
                 cmdAddBooking.Parameters.Add(paramBooking[1]);

                 paramBooking[2] = new SqlParameter("@userId", SqlDbType.NVarChar, 4);
                 paramBooking[2].Direction = ParameterDirection.Input;
                 paramBooking[2].Value = newBooking.UserID;
                 cmdAddBooking.Parameters.Add(paramBooking[2]);

                 paramBooking[3] = new SqlParameter("@booked_from", SqlDbType.DateTime);
                 paramBooking[3].Direction = ParameterDirection.Input;
                 paramBooking[3].Value = newBooking.BookedFrom;
                 cmdAddBooking.Parameters.Add(paramBooking[3]);

                 paramBooking[4] = new SqlParameter("@booked_to", SqlDbType.DateTime);
                 paramBooking[4].Direction = ParameterDirection.Input;
                 paramBooking[4].Value = newBooking.BookedTo;
                 cmdAddBooking.Parameters.Add(paramBooking[4]);

                 paramBooking[5] = new SqlParameter("@no_of_adults", SqlDbType.Int);
                 paramBooking[5].Direction = ParameterDirection.Input;
                 paramBooking[5].Value = newBooking.NoOfAdults;
                 cmdAddBooking.Parameters.Add(paramBooking[5]);

                 paramBooking[6] = new SqlParameter("@no_of_children", SqlDbType.Int);
                 paramBooking[6].Direction = ParameterDirection.Input;
                 paramBooking[6].Value = newBooking.NoOfChildren;
                 cmdAddBooking.Parameters.Add(paramBooking[6]);

                 paramBooking[7] = new SqlParameter("@amount", SqlDbType.Int);
                 paramBooking[7].Direction = ParameterDirection.Input;
                 paramBooking[7].Value = newBooking.Amount;
                 cmdAddBooking.Parameters.Add(paramBooking[7]);


                 int affectedRows = cmdAddBooking.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     BookingAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return BookingAdded;

         }


         /// <summary>
         /// To show User booking details
         /// </summary>
         /// <returns></returns>

         public static List<BookingDetails> ShowAllUserBookingDetailsDAL()
         {
             List<BookingDetails> BookingDetailsList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdshowBooking = conTraining.CreateCommand();
                 cmdshowBooking.CommandText = "GROUP3.USP_UserDisplayBookingDetails";

                 SqlDataReader readerBooking = null;
                 readerBooking = cmdshowBooking.ExecuteReader();

                 DataTable BookingDetailTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 BookingDetailTable.Load(readerBooking);
                 if (BookingDetailTable.Rows.Count > 0)
                 {
                     BookingDetailsList = new List<BookingDetails>();
                     foreach (DataRow row in BookingDetailTable.Rows)
                     {
                         BookingDetails BookingDetails1 = new BookingDetails();

                         BookingDetails1.BookingID = (string)(row[0]);
                         BookingDetails1.RoomID = (string)(row[1]);
                         BookingDetails1.UserID = (string)(row[2]);
                         BookingDetails1.BookedFrom = (DateTime)(row[3]);
                         BookingDetails1.BookedTo = (DateTime)(row[4]);
                         BookingDetails1.NoOfAdults = (int)(row[5]);
                         BookingDetails1.NoOfChildren = (int)(row[6]);
                         BookingDetails1.Amount = (int)(row[7]);

                         BookingDetailsList.Add(BookingDetails1);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return BookingDetailsList;
         }


         /// <summary>
         /// To show room booking details
         /// </summary>
         /// <param name="RoomId"></param>
         /// <returns></returns>
         public static List<BookingDetails> ShowAllRoomBookingDetailsDAL(string RoomId)
         {
             List<BookingDetails> BookingDetailsList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdshowBooking = conTraining.CreateCommand();
                 cmdshowBooking.CommandText = "GROUP3.USP_RoomDisplayBookingDetails";
                 SqlParameter paramBooking = new SqlParameter();

                 paramBooking = new SqlParameter("@room_id", SqlDbType.NVarChar, 4);
                 
                 paramBooking.Direction = ParameterDirection.Input;
                 paramBooking.Value = RoomId;
                 cmdshowBooking.Parameters.Add(paramBooking);

                 SqlDataReader readerBooking = null;
                 readerBooking = cmdshowBooking.ExecuteReader();

                 DataTable BookingDetailTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 BookingDetailTable.Load(readerBooking);
                 if (BookingDetailTable.Rows.Count > 0)
                 {
                     BookingDetailsList = new List<BookingDetails>();
                     foreach (DataRow row in BookingDetailTable.Rows)
                     {
                         BookingDetails BookingDetails1 = new BookingDetails();

                         BookingDetails1.BookingID = (string)(row[0]);
                         BookingDetails1.RoomID = (string)(row[1]);
                         BookingDetails1.UserID = (string)(row[2]);
                         BookingDetails1.BookedFrom = (DateTime)(row[3]);
                         BookingDetails1.BookedTo = (DateTime)(row[4]);
                         BookingDetails1.NoOfAdults = (int)(row[5]);
                         BookingDetails1.NoOfChildren = (int)(row[6]);
                         BookingDetails1.Amount = (int)(row[7]);

                         BookingDetailsList.Add(BookingDetails1);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return BookingDetailsList;
         }











         /// <summary>
         /// To add room details
         /// </summary>
         /// <param name="newRoom"></param>
         /// <returns></returns>

         public static bool AddRoomDAL(RoomDetails newRoom)
         {
             bool RoomAdded = false;
             try
             {
                 SqlCommand cmdAddRoom = new SqlCommand();
                 cmdAddRoom.Connection = conTraining;
                 cmdAddRoom.CommandType = CommandType.StoredProcedure;
                 cmdAddRoom.CommandText = "[GROUP3].[USP_InsertRoomDetails]";
                 conTraining.Open();
                 SqlParameter[] paramRoom = new SqlParameter[6];

                 paramRoom[0] = new SqlParameter("@hotel_id", SqlDbType.NVarChar, 4);
                 paramRoom[0].Direction = ParameterDirection.Input;
                 paramRoom[0].Value = newRoom.HotelID;
                 cmdAddRoom.Parameters.Add(paramRoom[0]);

                 paramRoom[1] = new SqlParameter("@room_id", SqlDbType.NVarChar, 4);
                 paramRoom[1].Direction = ParameterDirection.Input;
                 paramRoom[1].Value = newRoom.RoomID;
                 cmdAddRoom.Parameters.Add(paramRoom[1]);

                 paramRoom[2] = new SqlParameter("@room_no", SqlDbType.NVarChar, 3);
                 paramRoom[2].Direction = ParameterDirection.Input;
                 paramRoom[2].Value = newRoom.RoomNo;
                 cmdAddRoom.Parameters.Add(paramRoom[2]);

                 paramRoom[3] = new SqlParameter("@room_type", SqlDbType.NVarChar, 20);
                 paramRoom[3].Direction = ParameterDirection.Input;
                 paramRoom[3].Value = newRoom.RoomType;
                 cmdAddRoom.Parameters.Add(paramRoom[3]);

                 paramRoom[4] = new SqlParameter("@per_night_rate", SqlDbType.Int);
                 paramRoom[4].Direction = ParameterDirection.Input;
                 paramRoom[4].Value = newRoom.PerNightrate;
                 cmdAddRoom.Parameters.Add(paramRoom[4]);

                 paramRoom[5] = new SqlParameter("@RoomAvailability", SqlDbType.Int);
                 paramRoom[5].Direction = ParameterDirection.Input;
                 paramRoom[5].Value = newRoom.Availability;
                 cmdAddRoom.Parameters.Add(paramRoom[5]);

                 //paramRoom[6] = new SqlParameter("@photo", SqlDbType.Image);
                 //paramRoom[6].Direction = ParameterDirection.Input;
                 //paramRoom[6].Value = newRoom.photo;
                 //cmdAddRoom.Parameters.Add(paramRoom[6]);




                 int affectedRows = cmdAddRoom.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     RoomAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return RoomAdded;

         }


         /// <summary>
         /// To show room deatils
         /// </summary>
         /// <returns></returns>

         public static List<RoomDetails> ShowAllRoomDAL()
         {
             List<RoomDetails> RoomList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdshowRooms = conTraining.CreateCommand();
                 cmdshowRooms.CommandText = "GROUP3.USP_DisplayRoomDetails";

                 SqlDataReader readerRoom = null;
                 readerRoom = cmdshowRooms.ExecuteReader();

                 DataTable RoomTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 RoomTable.Load(readerRoom);
                 if (RoomTable.Rows.Count > 0)
                 {
                     RoomList = new List<RoomDetails>();
                     foreach (DataRow row in RoomTable.Rows)
                     {
                         RoomDetails Room = new RoomDetails();

                         Room.HotelID = (string)(row[0]);
                         Room.RoomID = (string)(row[1]);
                         Room.RoomNo = (string)(row[2]);
                         Room.RoomType = (string)(row[3]);
                         Room.PerNightrate = (int)(row[4]);
                         Room.Availability = (int)(row[5]);
                        // Room.photo = (string)(row[6]);

                         RoomList.Add(Room);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return RoomList;
         }



        /// <summary>
        /// Update the user on the basis of new data provided in update user form
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
         public static bool UpdateUserDAL(Users newUser)
         {
             bool UserAdded = false;
             try
             {
                 SqlCommand cmdUpdateUser = new SqlCommand();
                 cmdUpdateUser.Connection = conTraining;
                 cmdUpdateUser.CommandType = CommandType.StoredProcedure;
                 cmdUpdateUser.CommandText = "GROUP3.USP_UpdateUsers";
                 conTraining.Open();
                 SqlParameter[] paramUser = new SqlParameter[8];

                 paramUser[0] = new SqlParameter("@UserID", SqlDbType.NVarChar, 4);
                 paramUser[0].Direction = ParameterDirection.Input;
                 paramUser[0].Value = newUser.UserID;
                 cmdUpdateUser.Parameters.Add(paramUser[0]);

                 paramUser[1] = new SqlParameter("@UserPassWord", SqlDbType.NVarChar, 7);
                 paramUser[1].Direction = ParameterDirection.Input;
                 paramUser[1].Value = newUser.Password;
                 cmdUpdateUser.Parameters.Add(paramUser[1]);

                 paramUser[2] = new SqlParameter("@UserRole", SqlDbType.NVarChar, 7);
                 paramUser[2].Direction = ParameterDirection.Input;
                 paramUser[2].Value = newUser.Role;
                 cmdUpdateUser.Parameters.Add(paramUser[2]);

                 paramUser[3] = new SqlParameter("@UserName", SqlDbType.NVarChar, 7);
                 paramUser[3].Direction = ParameterDirection.Input;
                 paramUser[3].Value = newUser.UserName;
                 cmdUpdateUser.Parameters.Add(paramUser[3]);

                 paramUser[4] = new SqlParameter("@Mobile_no", SqlDbType.NVarChar, 7);
                 paramUser[4].Direction = ParameterDirection.Input;
                 paramUser[4].Value = newUser.MobileNo;
                 cmdUpdateUser.Parameters.Add(paramUser[4]);

                 paramUser[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 7);
                 paramUser[5].Direction = ParameterDirection.Input;
                 paramUser[5].Value = newUser.Phone;
                 cmdUpdateUser.Parameters.Add(paramUser[5]);

                 paramUser[6] = new SqlParameter("@UserAddress", SqlDbType.NVarChar, 7);
                 paramUser[6].Direction = ParameterDirection.Input;
                 paramUser[6].Value = newUser.Address;
                 cmdUpdateUser.Parameters.Add(paramUser[6]);

                 paramUser[7] = new SqlParameter("@email", SqlDbType.NVarChar, 7);
                 paramUser[7].Direction = ParameterDirection.Input;
                 paramUser[7].Value = newUser.Email;
                 cmdUpdateUser.Parameters.Add(paramUser[7]);


                 int affectedRows = cmdUpdateUser.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     UserAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return UserAdded;

         }




        /// <summary>
         ///  Update the Hotel on the basis of new data provided in update Hotel form
        /// </summary>
        /// <param name="newHotel"></param>
        /// <returns></returns>
         public static bool UpdateHotelDAL(Hotel newHotel)
         {
             bool HotelAdded = false;
             try
             {
                 SqlCommand cmdUpdateHotel = new SqlCommand();
                 cmdUpdateHotel.Connection = conTraining;
                 cmdUpdateHotel.CommandType = CommandType.StoredProcedure;
                 cmdUpdateHotel.CommandText = "GROUP3.USP_UpdateHotel";
                 conTraining.Open();
                 SqlParameter[] paramHotel = new SqlParameter[11];

                 paramHotel[0] = new SqlParameter("@hotel_id", SqlDbType.NVarChar, 4);
                 paramHotel[0].Direction = ParameterDirection.Input;
                 paramHotel[0].Value = newHotel.HotelID;
                 cmdUpdateHotel.Parameters.Add(paramHotel[0]);

                 paramHotel[1] = new SqlParameter("@city", SqlDbType.NVarChar, 10);
                 paramHotel[1].Direction = ParameterDirection.Input;
                 paramHotel[1].Value = newHotel.City;
                 cmdUpdateHotel.Parameters.Add(paramHotel[1]);

                 paramHotel[2] = new SqlParameter("@hotel_name", SqlDbType.NVarChar, 20);
                 paramHotel[2].Direction = ParameterDirection.Input;
                 paramHotel[2].Value = newHotel.HotelName;
                 cmdUpdateHotel.Parameters.Add(paramHotel[2]);

                 paramHotel[3] = new SqlParameter("@HotelAddress", SqlDbType.NVarChar, 25);
                 paramHotel[3].Direction = ParameterDirection.Input;
                 paramHotel[3].Value = newHotel.Address;
                 cmdUpdateHotel.Parameters.Add(paramHotel[3]);

                 paramHotel[4] = new SqlParameter("@HotelDescription", SqlDbType.NVarChar, 50);
                 paramHotel[4].Direction = ParameterDirection.Input;
                 paramHotel[4].Value = newHotel.Description;
                 cmdUpdateHotel.Parameters.Add(paramHotel[4]);

                 paramHotel[5] = new SqlParameter("@avg_rate_per_night", SqlDbType.Int);
                 paramHotel[5].Direction = ParameterDirection.Input;
                 paramHotel[5].Value = newHotel.AvgRatePerNight;
                 cmdUpdateHotel.Parameters.Add(paramHotel[5]);

                 paramHotel[6] = new SqlParameter("@phone_no1", SqlDbType.NVarChar, 10);
                 paramHotel[6].Direction = ParameterDirection.Input;
                 paramHotel[6].Value = newHotel.PhoneNo1;
                 cmdUpdateHotel.Parameters.Add(paramHotel[6]);

                 paramHotel[7] = new SqlParameter("@phone_no2", SqlDbType.NVarChar, 10);
                 paramHotel[7].Direction = ParameterDirection.Input;
                 paramHotel[7].Value = newHotel.PhoneNo2;
                 cmdUpdateHotel.Parameters.Add(paramHotel[7]);

                 paramHotel[8] = new SqlParameter("@rating", SqlDbType.NVarChar, 4);
                 paramHotel[8].Direction = ParameterDirection.Input;
                 paramHotel[8].Value = newHotel.Rating;
                 cmdUpdateHotel.Parameters.Add(paramHotel[8]);

                 paramHotel[9] = new SqlParameter("@email", SqlDbType.NVarChar, 15);
                 paramHotel[9].Direction = ParameterDirection.Input;
                 paramHotel[9].Value = newHotel.Email;
                 cmdUpdateHotel.Parameters.Add(paramHotel[9]);

                 paramHotel[10] = new SqlParameter("@fax", SqlDbType.NVarChar, 15);
                 paramHotel[10].Direction = ParameterDirection.Input;
                 paramHotel[10].Value = newHotel.Fax;
                 cmdUpdateHotel.Parameters.Add(paramHotel[10]);


                 int affectedRows = cmdUpdateHotel.ExecuteNonQuery();// DataConnection.ExecuteNonQueryCommand(cmdAddProduct);


                 if (affectedRows > 0)
                     HotelAdded = true;
             }

             catch (HMS_Exception)
             { throw; }
             catch (SqlException)
             {
                 throw;
             }
             catch (Exception)
             { throw; }

             conTraining.Close();

             return HotelAdded;

         }






        /// <summary>
        /// Function to search hotel on basis of the City entered by user
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
         public static List<Hotel> SearchHotelDAL(string city)
         {
             List<Hotel> HotelList = null;
             try
             {
                 conTraining.Open();
                 SqlCommand cmdAddHotel = new SqlCommand();
                 cmdAddHotel.Connection = conTraining;
                 cmdAddHotel.CommandType = CommandType.StoredProcedure;
                 //conTraining.Open();
                 //await conTraining.OpenAsync();
                 cmdAddHotel.CommandText = "GROUP3.USP_SearchHotel";

                 SqlParameter[] paramSearch = new SqlParameter[1];



                 paramSearch[0] = new SqlParameter("@city", SqlDbType.VarChar, 10);
                 paramSearch[0].Direction = ParameterDirection.Input;
                 paramSearch[0].Value = city;
                 cmdAddHotel.Parameters.Add(paramSearch[0]);
                 SqlDataReader readerHotel = null;
                 readerHotel = cmdAddHotel.ExecuteReader();

                 DataTable HotelTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 HotelTable.Load(readerHotel);
                 if (HotelTable.Rows.Count > 0)
                 {
                     HotelList = new List<Hotel>();
                     foreach (DataRow row in HotelTable.Rows)
                     {
                         Hotel Hotel1 = new Hotel();

                         Hotel1.HotelID = (string)(row[0]);
                         Hotel1.City = (string)(row[1]);
                         Hotel1.HotelName = (string)(row[2]);
                         Hotel1.Address = (string)(row[3]);
                         Hotel1.Description = (string)(row[4]);
                         Hotel1.AvgRatePerNight = (int)(row[5]);
                         Hotel1.PhoneNo1 = (string)(row[6]);
                         Hotel1.PhoneNo2 = (string)(row[7]);
                         Hotel1.Rating = (string)(row[8]);
                         Hotel1.Email = (string)(row[9]);
                         Hotel1.Fax = (string)(row[10]);

                         HotelList.Add(Hotel1);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return HotelList;
         }







        /// <summary>
        /// Function to generate history of user bookings
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
         public static List<BookingDetails> FilteredBookingDAL(string user)
         {
             List<BookingDetails> BookList = null;
             try
             {
                 conTraining.Open();
                 
                 SqlCommand cmdAddbooking = new SqlCommand();
                 cmdAddbooking.Connection = conTraining;
                 cmdAddbooking.CommandType = CommandType.StoredProcedure;
                 //conTraining.Open();
                 //await conTraining.OpenAsync();
                 cmdAddbooking.CommandText = "GROUP3.[USP_UserDisplayBookingDetails]";

                 SqlParameter[] paramBooking = new SqlParameter[1];



                 paramBooking[0] = new SqlParameter("@userId", SqlDbType.VarChar, 10);
                 paramBooking[0].Direction = ParameterDirection.Input;
                 paramBooking[0].Value = user;
                 cmdAddbooking.Parameters.Add(paramBooking[0]);
                 SqlDataReader readerHotel = null;
                 readerHotel = cmdAddbooking.ExecuteReader();

                 DataTable BookTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 BookTable.Load(readerHotel);
                 if (BookTable.Rows.Count > 0)
                 {
                     BookList = new List<BookingDetails>();
                     foreach (DataRow row in BookTable.Rows)
                     {
                         BookingDetails Book1 = new BookingDetails();

                         Book1.BookingID = (string)(row[0]);
                         Book1.RoomID = (string)(row[1]);
                         Book1.UserID = (string)(row[2]);
                         Book1.BookedFrom = (DateTime)(row[3]);
                         Book1.BookedTo = (DateTime)(row[4]);
                         Book1.NoOfAdults = (int)(row[5]);
                         Book1.NoOfChildren = (int)(row[6]);
                         Book1.Amount = (int)(row[7]);
                            BookList.Add(Book1);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return BookList;
         }




        /// <summary>
        /// Function to generate the room list entered by the hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
         public static List<RoomDetails> FilterRoomsDAL(string hotel)
         {
             List<RoomDetails> BookList = null;
             try
             {
                 conTraining.Open();

                 SqlCommand cmdAddRoom = new SqlCommand();
                 cmdAddRoom.Connection = conTraining;
                 cmdAddRoom.CommandType = CommandType.StoredProcedure;
                 //conTraining.Open();
                 //await conTraining.OpenAsync();
                 cmdAddRoom.CommandText = "[GROUP3].[USP_DisplayRoomDetails]";

                 SqlParameter[] paramRoom = new SqlParameter[1];



                 paramRoom[0] = new SqlParameter("@hotel_id", SqlDbType.VarChar, 10);
                 paramRoom[0].Direction = ParameterDirection.Input;
                 paramRoom[0].Value = hotel;
                 cmdAddRoom.Parameters.Add(paramRoom[0]);
                 SqlDataReader readerHotel = null;
                 readerHotel = cmdAddRoom.ExecuteReader();

                 DataTable BookTable = new DataTable();
                 //Load the Data into the table from the Datareader.
                 BookTable.Load(readerHotel);
                 if (BookTable.Rows.Count > 0)
                 {
                     BookList = new List<RoomDetails>();
                     foreach (DataRow row in BookTable.Rows)
                     {
                         RoomDetails Room = new RoomDetails();

                         Room.HotelID = (string)(row[0]);
                         Room.RoomID = (string)(row[1]);
                         Room.RoomNo = (string)(row[2]);
                         Room.RoomType = (string)(row[3]);
                         Room.PerNightrate = (int)(row[4]);
                         Room.Availability = (int)(row[5]);
                        
                         BookList.Add(Room);
                     }

                 }
                 else throw new HMS_Exception("No Records Found");
             }
             catch (HMS_Exception)
             { throw; }
             catch (SqlException ex)
             {
                 throw ex;
             }
             catch (SystemException ex)
             { throw ex; }
             finally
             {
                 conTraining.Close();
             }
             return BookList;
         }


    }
}
