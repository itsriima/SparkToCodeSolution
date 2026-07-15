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
    }
}
