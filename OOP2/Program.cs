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
            UpdateRoomPrice();
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
            string guestId = "G" + (guests.Count + 1).ToString("000");
            Guest newGuest = new Guest();
            newGuest.CheckInDate = DateTime.Parse(checkInDate);

            Console.Write("Enter total nights: ");
            int totalNights = int.Parse(Console.ReadLine());
            if (totalNights <= 0)
            {
                Console.WriteLine("Total nights must be positive.");
                return;
            }
            newGuest.GuestId = guestId;
            newGuest.GuestName = guestName;
            newGuest.CheckInDate = DateTime.Parse(checkInDate);
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
        //Case 04- View All Rooms 
        //////////////////////////////////////
        static void ViewAllRooms()
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }


            Console.WriteLine("Total Rooms: " + rooms.Count());


            var roomList = rooms
                .OrderBy(r => r.RoomNumber)
                .Select(r => new
                {
                    r.RoomNumber,
                    r.RoomType,
                    r.PricePerNight,
                    r.IsAvailable
                });


            foreach (var room in roomList)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Room Number: " + room.RoomNumber);
                Console.WriteLine("Room Type: " + room.RoomType);
                Console.WriteLine("Price Per Night: " + room.PricePerNight);

                if (room.IsAvailable)
                {
                    Console.WriteLine("Status: Available");
                }
                else
                {
                    Console.WriteLine("Status: Booked");
                }
            }
        }
            //Case 05- View All Guests 10 pts
            static void ViewAllGuests()
            {
                // Check if the guests list is empty
                if (guests.Count() == 0)
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                // Display total number of guests
                Console.WriteLine("Total Guests: " + guests.Count());
                Console.WriteLine("----------------------------------");

                // Sort guests by name and select required information
                var guestList = guests
                    .OrderBy(g => g.GuestName)
                    .Select(g => new
                    {
                        g.GuestId,
                        g.GuestName,
                        g.RoomNumber,
                        g.CheckInDate,
                        g.TotalNights
                    });

                // Display all guests
                foreach (var guest in guestList)
                {
                    Console.WriteLine("Guest ID: " + guest.GuestId);
                    Console.WriteLine("Guest Name: " + guest.GuestName);
                    Console.WriteLine("Room Number: " + guest.RoomNumber);
                    Console.WriteLine("Check-In Date: " + guest.CheckInDate);
                    Console.WriteLine("Total Nights: " + guest.TotalNights);
                    Console.WriteLine("----------------------------------");
                }
            }
        //Case 06 Search & Filter Rooms 
        static void SearchFilterRooms()
        {
            Console.WriteLine("===== Search & Filter Rooms =====");
            Console.WriteLine("1. Show All Available Rooms");
            Console.WriteLine("2. Filter by Room Type");
            Console.WriteLine("3. Filter by Max Price");
            Console.WriteLine("4. Room Price Statistics");
            Console.WriteLine("0. Back");

            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                    // case 1:

                    var availableRooms =
                    rooms.Where(r => r.IsAvailable)
                    .OrderBy(r => r.PricePerNight);

                    break;
                    Console.WriteLine("Available Rooms: "
                    + availableRooms.Count());
                    if (availableRooms.Count() == 0)
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        break;
                    }

                    foreach (var room in availableRooms)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Room Number: " + room.RoomNumber);
                        Console.WriteLine("Room Type: " + room.RoomType);
                        Console.WriteLine("Price: " + room.PricePerNight.ToString("F2"));
                    }
            }
        }
            //Case 07 - Guest & Booking Statistics
            /////////////////////////////////////////////////
            static void GuestBookingStatistics()
            {
                //Total guests and guests with a reservation
                Console.WriteLine("===== Guest & Booking Statistics =====");

                Console.WriteLine("Total Registered Guests: " + guests.Count());

                Console.WriteLine("Guests With Active Booking: " +
                    guests.Count(g => g.RoomNumber != "Not Assigned"));
                //Room statistics
                Console.WriteLine("Total Rooms: " + rooms.Count());
                Console.WriteLine("Booked Rooms: " +
                    rooms.Count(r => !r.IsAvailable));
                //Are there any reservations?
                if (!guests.Any(g => g.RoomNumber != "Not Assigned"))
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }
                    //Average number of nights
                    double averageNights =
                    guests
                    .Where(g => g.RoomNumber != "Not Assigned")
                    .Average(g => g.TotalNights);

                    Console.WriteLine("Average Nights: " +
                        averageNights.ToString("F2"));
                    //Top 3 guests who paid the most
                    var topGuests =
                    guests
                    .Where(g => g.RoomNumber != "Not Assigned")
                    .OrderByDescending(g =>
                    g.CalculateTotalCost(
                    rooms.First(r => r.RoomNumber.ToString() == g.RoomNumber)
                   .PricePerNight))
                   .Take(3);

                foreach (var guest in topGuests)
                {
                    Room room =
                        rooms.First(r => r.RoomNumber.ToString() == guest.RoomNumber);

                    double total =
                        guest.CalculateTotalCost(room.PricePerNight);

                    Console.WriteLine("Guest Name: " + guest.GuestName);
                    Console.WriteLine("Room Number: " + guest.RoomNumber);
                    Console.WriteLine("Total Cost: OMR " + total.ToString("F2"));
                    Console.WriteLine("--------------------------------");
                }
                //Summary using Select
                var summary =
                guests
                .Where(g => g.RoomNumber != "Not Assigned")
                .Select(g =>
                {
                Room room =
                rooms.First(r => r.RoomNumber.ToString() == g.RoomNumber);

                double total =
                g.CalculateTotalCost(room.PricePerNight);

                return $"{g.GuestName} - Room {g.RoomNumber} - {g.TotalNights} nights - OMR {total:F2}";
                });
                Console.WriteLine();
                Console.WriteLine("===== Booking Summary =====");
                foreach (var item in summary)
                {
                    Console.WriteLine(item);
                }
            }
        // Case 08 - Update Room Price
        ////////////////////////////////////
        static void UpdateRoomPrice()
        {
            // Ask the user to enter the room number
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            //Search for the room using LINQ FirstOrDefault()
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            //Check if the room exists
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            // Ask the user for the new price
            Console.Write("Enter new price per night: ");
            double newPrice = double.Parse(Console.ReadLine());

            // Validate that the price is positive
            if (newPrice <= 0)
            {
                Console.WriteLine("Price must be positive.");
                return;
            }

            //Save the old price before updating
            double oldPrice = room.PricePerNight;

            // Update the room price
            room.PricePerNight = newPrice;

            //Display confirmation
            Console.WriteLine();
            Console.WriteLine("Room price updated successfully!");
            Console.WriteLine("Room Number: " + room.RoomNumber);
            Console.WriteLine("Old Price: OMR " + oldPrice.ToString("F2"));
            Console.WriteLine("New Price: OMR " + room.PricePerNight.ToString("F2"));
        }
    }

}






