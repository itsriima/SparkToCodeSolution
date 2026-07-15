namespace OOP2
{
    internal class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();
        static void Main(string[] args)
        {
            rooms.Add(new Room
            {
                RoomNumber = 101,
                RoomType = "Single",
                PricePerNight = 25,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 102,
                RoomType = "Single",
                PricePerNight = 30,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 201,
                RoomType = "Double",
                PricePerNight = 45,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 202,
                RoomType = "Double",
                PricePerNight = 50,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 301,
                RoomType = "Suite",
                PricePerNight = 80,
                IsAvailable = true
            });

            rooms.Add(new Room
            {
                RoomNumber = 302,
                RoomType = "Suite",
                PricePerNight = 100,
                IsAvailable = true
            });
            //foreach (Room room in rooms)
            //{
            //    room.DisplayRoom();
            //    Console.WriteLine();
            //}
        }
        //Case 01 Add New Room
        //////////////////////////////////////
        static void AddNewRoom()
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            if (roomNumber <= 0)
            {
                Console.WriteLine("Room number must be positive.");
                return;
            }
            Console.Write("Enter room type: ");
            string roomType = Console.ReadLine();
            Console.Write("Enter price per night: ");
            double pricePerNight = double.Parse(Console.ReadLine());
            if (pricePerNight <= 0)
            {
                Console.WriteLine("Price must be positive.");
                return;
            }
            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine("Room number already exists.");
                return;
            }
            Room newRoom = new Room();

            newRoom.RoomNumber = roomNumber;
            newRoom.RoomType = roomType;
            newRoom.PricePerNight = pricePerNight;
            newRoom.IsAvailable = true;
            rooms.Add(newRoom);
            Console.WriteLine("Room added successfully!");
            Console.WriteLine("Room Number: " + newRoom.RoomNumber);
            Console.WriteLine("Room Type: " + newRoom.RoomType);
            Console.WriteLine("Price Per Night: " + newRoom.PricePerNight);
            Console.WriteLine("Available: " + newRoom.IsAvailable);
            Console.WriteLine("Total Rooms: " + rooms.Count);
        }
        // Case 02 - Register New Guest
        ////////////////////////////////////

        static void RegisterNewGuest()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter check-in date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter total nights: ");
            int totalNights = int.Parse(Console.ReadLine());
            if (totalNights <= 0)
            {
                Console.WriteLine("Total nights must be positive.");
                return;
            }

            string guestId = "G" + (guests.Count + 1).ToString("000");
            Guest newGuest = new Guest();
            newGuest.GuestId = guestId;
            newGuest.GuestName = guestName;
            newGuest.CheckInDate = checkInDate;
            newGuest.TotalNights = totalNights;
            newGuest.RoomNumber = "Not Assigned";

            guests.Add(newGuest);

            Console.WriteLine("Guest registered successfully!");
            Console.WriteLine("Guest ID: " + newGuest.GuestId);
            Console.WriteLine("Guest Name: " + newGuest.GuestName);
            Console.WriteLine("Room Number: " + newGuest.RoomNumber);
            Console.WriteLine("Check In Date: " + newGuest.CheckInDate);
            Console.WriteLine("Total Nights: " + newGuest.TotalNights);
        }
        //Case 03- Book a Room for a Guest
        /// //////////////////////////////////////
        static void BookRoom()
        {
            Console.Write("Enter guest ID: ");
            string guestId = Console.ReadLine();

            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }
            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }
            guest.RoomNumber = roomNumber.ToString();
            room.IsAvailable = false;
            double totalCost = guest.CalculateTotalCost(room.PricePerNight);

            Console.WriteLine("\nBooking Confirmed!");
            Console.WriteLine("Guest Name: " + guest.GuestName);
            Console.WriteLine("Room Number: " + guest.RoomNumber);
            Console.WriteLine("Room Type: " + room.RoomType);
            Console.WriteLine("Price Per Night: " + room.PricePerNight);
            Console.WriteLine("Total Nights: " + guest.TotalNights);
            Console.WriteLine("Total Cost: " + totalCost);
        }
    }
}
