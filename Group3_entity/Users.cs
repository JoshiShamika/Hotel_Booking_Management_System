using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_entity
{
    /// <summary>
    /// Class having members of HMS declared
    /// Author:Group3
    /// Date of Creation:22-Oct-2016
    /// </summary>
    /// 

    public class Users
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public Users()
        {
            UserID = "unknown";
            Password = "unknown";
            Role = "unknown";
            UserName = "unknown";
            MobileNo = "unknown";
            Phone = "unknown";
            Address = "unknown";
            Email = "unknown";
        }

    }

    public class Admin {
        public string AdminUserName { get; set; }
        public string AdminPwd { get; set; }
    }


    public class User
    {
        public string UserID { get; set; }
        public string UserPassWord { get; set; }
    }


    public class Hotel
    {
        public string HotelID { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int AvgRatePerNight { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string Rating { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }


        public Hotel()
        {
            HotelID = "Unkown";
            City = "Unkown";
            HotelName = "Unkown";
            Address = "Unkown";
            Description = "Unkown";
            AvgRatePerNight = 0;
            PhoneNo1 = "Unkown";
            PhoneNo2 = "Unkown";
            Rating = "Unkown";
            Email = "Unkown";
            Fax = "Unkown";
        }
    }

    public class RoomDetails
    {
        public string HotelID { get; set; }
        public string RoomID { get; set; }
        public string RoomNo { get; set; }
        public string RoomType { get; set; }
        public int PerNightrate { get; set; }
        public int Availability { get; set; }
       // public byte photo { get; set; }


        public RoomDetails()
        {
            HotelID = "Unkown";
            RoomID = "Unkown";
            RoomNo = "Unkown";
            RoomType = "Unkown";
            PerNightrate = 0;
            Availability = 0;
        }
    }

    public static class LoginInfo {
        public static string UserId { get; set; }
    }

    public class BookingDetails
    {
        public string BookingID { get; set; }
        public string UserID { get; set; }
        public string RoomID { get; set; }
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        public int NoOfAdults { get; set; }
        public int NoOfChildren { get; set; }
        public int Amount { get; set; }


        public BookingDetails()
        {
            BookingID = "Unkown";
            UserID = "Unkown";
            RoomID = "Unkown";
            //BookedFrom = null;
            // BookedTo = null;
            NoOfAdults = 0;
            NoOfChildren = 0;
            Amount = 0;
        }
    } 
}
