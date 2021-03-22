using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Group3_Exception;
using Group3_entity;
using Group3_Dal;
using System.Text.RegularExpressions;

namespace Group3_BLL
{
    public class HBMS_BLL
    {



        /// <summary>
        /// To Add Hotels using DAL function
        /// </summary>
        /// <param name="Hotels"></param>
        /// <returns></returns>
        public static bool AddHotelBL(Hotel Hotels)
        {
            bool Hoteladded = false;
            try
            {
                 if (ValidateHotel(Hotels))
                {
                    Hoteladded = HMS_DAL.AddHotelDAL(Hotels);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Hoteladded;
        }

        
        /// <summary>
        /// Function to validate Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        private static bool ValidateHotel(Hotel hotel)
        {

            bool validhotel = true;
            StringBuilder message = new StringBuilder();
            //validating for first name 
            if ((hotel.HotelID.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel ID is Required");

            }

            if (!(Regex.IsMatch(hotel.HotelID, @"^[0-9]{4}$")))
            {
                validhotel = false;
                message.Append(Environment.NewLine + "Hotel id must Contain 4 digits only");
            }

           

            if ((hotel.HotelName.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Name is Required");

            }

            if ((hotel.City.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " City is Required");

            }

            if ((hotel.Address.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Address is Required");

            }

            if ((hotel.Description.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Description is Required");

            }

            if (hotel.AvgRatePerNight.ToString().Equals(string.Empty))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " hotel Average rate is required ");
            }

            if ((hotel.PhoneNo1.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Phone Number is Required");

            }
            if (!(Regex.IsMatch(hotel.PhoneNo1, @"^[7-9][0-9]{9}$")))
            {
                validhotel = false;
                message.Append(Environment.NewLine + "Enter Phone number in proper format");
            }

            if ((hotel.PhoneNo2.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Phone Number is Required");

            }

            if (!(Regex.IsMatch(hotel.PhoneNo2, @"^[7-9][0-9]{9}$")))
            {
                validhotel = false;
                message.Append(Environment.NewLine + "Enter Phone number in proper format");
            }

            if ((hotel.Rating.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Rating is Required");

            }

            if (!(Regex.IsMatch(hotel.Rating, @"^[1-5]$")))
            {
                validhotel = false;
                message.Append(Environment.NewLine + "Enter Phone number in proper format");
            }

            if ((hotel.Email.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Email is Required");

            }

            if (!(Regex.IsMatch(hotel.Email, @"^[A-Z a-z]+[a-z A-Z 0-9]+[@]+[a-z]+[.][a-z]+$")))
            {
                validhotel = false;
                message.Append(Environment.NewLine + "Hotel Email must be in the proper format");
            }

            if ((hotel.Fax.Length == 0))
            {
                validhotel = false;
                message.Append(Environment.NewLine + " Hotel Fax is Required");

            }


            if (validhotel == false)
            {
                throw new HMS_Exception(message.ToString());
            }
            return validhotel;
        }

        /// <summary>
        /// Function to validate user
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        private static bool ValidateUser(Users User)
        {

            bool validuser = true;
            StringBuilder message = new StringBuilder();
            //validating for first name 
            if ((User.UserID.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + " User ID is Required");

            }

            if (!(Regex.IsMatch(User.UserID, @"^[0-9]{4}$")))
            {
                validuser = false;
                message.Append(Environment.NewLine + "User id must Contain 4 digits only");
            }



            if ((User.Password.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + " Password is Required");

            }

            if ((User.Role.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + " Role is Required");

            }

            if ((User.UserName.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + "User Name is Required");

            }

            if ((User.MobileNo.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + "Mobile No is Required");

            }

            if (!(Regex.IsMatch(User.MobileNo, @"^[7-9][0-9]{9}$")))
            {
                validuser = false;
                message.Append(Environment.NewLine + "Enter Mobile number in proper format");
            }

            if (User.Phone.ToString().Equals(string.Empty))
            {
                validuser = false;
                message.Append(Environment.NewLine + "Phone Number rate is required ");
            }

            if (!(Regex.IsMatch(User.Phone, @"^[7-9][0-9]{9}$")))
            {
                validuser = false;
                message.Append(Environment.NewLine + "Enter Phone number in proper format");
            }

            if ((User.Address.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + " Address is Required");

            }


            if ((User.Email.Length == 0))
            {
                validuser = false;
                message.Append(Environment.NewLine + " Email is Required");

            }

            if (!(Regex.IsMatch(User.Email, @"^[A-Z a-z]+[a-z A-Z 0-9]+[@]+[a-z]+[.][a-z]+$")))
            {
                validuser = false;
                message.Append(Environment.NewLine + "User Email must be in the proper format");
            }


            if (validuser == false)
            {
                throw new HMS_Exception(message.ToString());
            }
            return validuser;
        }

        /// <summary>
        /// Function to validate Room
        /// </summary>
        /// <param name="Room"></param>
        /// <returns></returns>
        private static bool ValidateRoom(RoomDetails Room)
        {

            bool validroom = true;
            StringBuilder message = new StringBuilder();
            //validating for first name 
            if ((Room.HotelID.Length == 0))
            {
                validroom = false;
                message.Append(Environment.NewLine + " Hotel ID is Required");

            }

            if (!(Regex.IsMatch(Room.HotelID, @"^[0-9]{4}$")))
            {
                validroom = false;
                message.Append(Environment.NewLine + "Hotel id must Contain 4 digits only");
            }



            if ((Room.RoomID.Length == 0))
            {
                validroom = false;
                message.Append(Environment.NewLine + " Room ID is Required");

            }

            if (!(Regex.IsMatch(Room.RoomID, @"^[0-9]{4}$")))
            {
                validroom = false;
                message.Append(Environment.NewLine + "Room id must Contain 4 digits only");
            }

            if ((Room.RoomNo.Length == 0))
            {
                validroom = false;
                message.Append(Environment.NewLine + " Room number is Required");

            }

            if ((Room.RoomType.Length == 0))
            {
                validroom = false;
                message.Append(Environment.NewLine + "Room Type is Required");

            }

            if (Room.PerNightrate.ToString().Equals(string.Empty))
            {
                validroom = false;
                message.Append(Environment.NewLine + " Per Night Rate is required");
            }

            if (Room.Availability.ToString().Equals(string.Empty))
            {
                validroom = false;
                message.Append(Environment.NewLine + " Per Night Rate is required");
            }

            //if (Room.photo.ToString().Equals(string.Empty))
            //{
            //    validroom = false;
            //    message.Append(Environment.NewLine + "Phone Number rate is required ");
            //}


            if (validroom == false)
            {
                throw new HMS_Exception(message.ToString());
            }
            return validroom;
        }

        /// <summary>
        /// Function to validate Bookings
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        private static bool ValidateBooking(BookingDetails book)
        {

            bool validbooking = true;
            StringBuilder message = new StringBuilder();
            //validating for first name 
            if ((book.BookingID.Length == 0))
            {
                validbooking = false;
                message.Append(Environment.NewLine + " Booking ID is Required");

            }

            if (!(Regex.IsMatch(book.BookingID, @"^[0-9]{4}$")))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "Booking id must Contain 4 digits only");
            }



            if ((book.RoomID.Length == 0))
            {
                validbooking = false;
                message.Append(Environment.NewLine + " Room ID is Required");

            }

            if (!(Regex.IsMatch(book.RoomID, @"^[0-9]{4}$")))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "Room id must Contain 4 digits only");
            }

            if ((book.UserID.Length == 0))
            {
                validbooking = false;
                message.Append(Environment.NewLine + " Room number is Required");

            }

             if (!(Regex.IsMatch(book.UserID, @"^[0-9]{4}$")))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "User id must Contain 4 digits only");
            }


             if (book.BookedFrom.ToString().Equals(string.Empty))
             {
                 validbooking = false;
                 message.Append(Environment.NewLine + "Booking Date is required");
             }

            if (book.BookedTo.ToString().Equals(string.Empty))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "Booking Date is required");
            }

            if (book.NoOfAdults.ToString().Equals(string.Empty))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "No Of Adults is required");
            }

            if (book.NoOfChildren.ToString().Equals(string.Empty))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "No Of Children  is required ");
            }

            if (book.Amount.ToString().Equals(string.Empty))
            {
                validbooking = false;
                message.Append(Environment.NewLine + "Amount is required ");
            }

            if (validbooking == false)
            {
                throw new HMS_Exception(message.ToString());
            }
            return validbooking;
        }

            


        

        /// <summary>
        /// To Display Hotels
        /// </summary>
        /// <returns></returns>
        public static List<Hotel> DisplayAllHotelBL()
        {
            List<Hotel> Hlist = new List<Hotel>();
            try
            {
                Hlist = HMS_DAL.ShowAllHotelDAL();
                if (Hlist == null)
                    throw new HMS_Exception("No Hotel Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Hlist; // Returns the list of Hotel

        }



        /// <summary>
        /// To add Users
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool AddUserBL(Users User)
        {
            bool Useradded = false;
            try
            {
               if (ValidateUser(User))
                {
                    Useradded = HMS_DAL.AddUserDAL(User);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Useradded;
        }

       
        /// <summary>
        /// Function to display users
        /// </summary>
        /// <returns></returns>
        public static List<Users> DisplayAllUserBL()
        {
            List<Users> Ulist = new List<Users>();
            try
            {
                Ulist = HMS_DAL.ShowAllUsersDAL();
                if (Ulist == null)
                    throw new HMS_Exception("No User Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Ulist; // Returns the list of User

        }



        /// <summary>
        /// Admin Login
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool AdminLoginBL(Admin Admin)
        {
            bool AdminLogin = false;
            try
            {
                //if (ValidateLogin(Admin))
                {
                    AdminLogin = HMS_DAL.AdminLoginDetailsDAL(Admin);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return AdminLogin;
        }

        /// <summary>
        /// User Login function
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool UserLoginBL(User user)
        {
            bool UserLoginBL = false;
            try
            {
                //if (ValidateLogin(Admin))
                {
                    UserLoginBL = HMS_DAL.UserLoginDetailsDAL(user);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return UserLoginBL;
        }


        /// <summary>
        /// Hotel Login function
        /// </summary>
        /// <param name="Hotel"></param>
        /// <returns></returns>
        public static bool HotelLoginBL(Hotel Hotel)
        {
            bool HotelLoginBL = false;
            try
            {
                //if (ValidateLogin(Admin))
                {
                    HotelLoginBL = HMS_DAL.HotelLoginDetailsDAL(Hotel);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return HotelLoginBL;
        }


        /// <summary>
        /// Add bookings function
        /// </summary>
        /// <param name="Book"></param>
        /// <returns></returns>
        public static bool AddBookingBL(BookingDetails Book)
        {
            bool Bookingadded = false;
            try
            {
                //if (ValidateBooking(Book))
                {
                    Bookingadded = HMS_DAL.AddBookingDetailsDAL(Book);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Bookingadded;
        }


       






        /// <summary>
        /// Display User bookings
        /// </summary>
        /// <returns></returns>
        public static List<BookingDetails> DisplayAllUserBookingBL()
        {
            List<BookingDetails> Blist = new List<BookingDetails>();
            try
            {
                Blist = HMS_DAL.ShowAllUserBookingDetailsDAL();
                if (Blist == null)
                    throw new HMS_Exception("No Booking Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Blist; // Returns the list of booking

        }

        




        /// <summary>
        /// To Display Bookings according to Rooms
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static List<BookingDetails> DisplayAllRoomBookingBL(string RoomId)
        {
            List<BookingDetails> rlist = new List<BookingDetails>();
            try
            {
                rlist = HMS_DAL.ShowAllRoomBookingDetailsDAL(RoomId);
                if (rlist == null)
                    throw new HMS_Exception("No Booking Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rlist; // Returns the list of Booking

        }




        /// <summary>
        /// To Add Room
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>

        public static bool AddRoomBL(RoomDetails room)
        {
            bool Roomadded = false;
            try
            {
                //if (ValidateRoom(room))
                {
                    Roomadded = HMS_DAL.AddRoomDAL(room);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Roomadded;
        }

       

       
        /// <summary>
        ///  To Display Rooms
        /// </summary>
        /// <returns></returns>
        public static List<RoomDetails> DisplayAllRoomBL()
        {
            List<RoomDetails> rlist = new List<RoomDetails>();
            try
            {
                rlist = HMS_DAL.ShowAllRoomDAL();
                if (rlist == null)
                    throw new HMS_Exception("No room Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rlist; // Returns the list of Room

        }



        /// <summary>
        /// Update user function
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool UpdatdeUserBL(Users User)
        {
            bool Useradded = false;
            try
            {
               // if (ValidateUser(User))
                {
                    Useradded = HMS_DAL.UpdateUserDAL(User);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Useradded;
        }

        /// <summary>
        /// Update Hotel function
        /// </summary>
        /// <param name="Hotels"></param>
        /// <returns></returns>
        public static bool UpdateHotelBL(Hotel Hotels)
        {
            bool Hoteladded = false;
            try
            {
                //if (ValidateHotel(Hotels))
                {
                    Hoteladded = HMS_DAL.UpdateHotelDAL(Hotels);

                }
            }
            catch (HMS_Exception e)
            { throw e; }
            return Hoteladded;
        }


        /// <summary>
        /// Search hotel on basis of city
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public static List<Hotel> SearchAllHotelBL(string city)
        {
            List<Hotel> Hlist = new List<Hotel>();
            try
            {
                Hlist = HMS_DAL.SearchHotelDAL(city);
                if (Hlist == null)
                    throw new HMS_Exception("No Hotel Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Hlist; // Returns the list of Hotel

        }




        /// <summary>
        /// User booking history 
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static List<BookingDetails> FilteredBookingBL(string User)
        {
            List<BookingDetails> Blist = new List<BookingDetails>();
            try
            {
                Blist = HMS_DAL.FilteredBookingDAL(User);
                if (Blist == null)
                    throw new HMS_Exception("No Booking Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Blist; // Returns the list of Hotel

        }



        /// <summary>
        /// Function to display rooms for hotels
        /// </summary>
        /// <param name="Hotel"></param>
        /// <returns></returns>
        public static List<RoomDetails> FilteredRoomBL(string Hotel)
        {
            List<RoomDetails> Blist = new List<RoomDetails>();
            try
            {
                Blist = HMS_DAL.FilterRoomsDAL(Hotel);
                if (Blist == null)
                    throw new HMS_Exception("No Room Found");
            }
            catch (HMS_Exception p)
            {
                throw p;
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Blist; // Returns the list of Hotel

        }



    }
}
