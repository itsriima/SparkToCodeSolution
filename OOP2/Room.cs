using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    internal class Room
    {
        // Attributes (Properties)
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Method
        public void DisplayRoom()
        {
            Console.WriteLine("Room Number: " + RoomNumber);
            Console.WriteLine("Room Type: " + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);
            Console.WriteLine("Available: " + IsAvailable);
        }
    }
}
