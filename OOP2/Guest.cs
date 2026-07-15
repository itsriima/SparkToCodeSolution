using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class Guest
    {
        // Attributes (Properties)
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        // Method
        public void DisplayGuest()
        {
            Console.WriteLine("Guest ID: " + GuestId);
            Console.WriteLine("Guest Name: " + GuestName);
            Console.WriteLine("Room Number: " + RoomNumber);
            Console.WriteLine("Check In Date: " + CheckInDate.ToShortDateString());
            Console.WriteLine("Total Nights: " + TotalNights);
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return pricePerNight * TotalNights;
        }
    }
}
