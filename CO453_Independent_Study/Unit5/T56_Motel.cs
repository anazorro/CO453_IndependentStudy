using System;

namespace CO453_Independent_Study.Unit5
{
    /// <summary>
    /// This class will simulate a booking system for the Bates Motel
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 17/02/2019
    /// Last Update:03/03/2019
    /// </summary>
    class T56_Motel
    {
        private static int[] rooms;
        private static int[] guests;
        private const int MAX = 20;
        private static int roomNumber, numberOfGuests;

        /// <summary>
        /// This is the constructor method
        /// </summary>
        public T56_Motel()
        {
            rooms = new int[MAX]; //Allow room numbers from 1 to 20
            guests = new int[MAX];
        }

        /// <summary>
        /// This method will allow the user to choose from the menu
        /// </summary>
        public static void RunMotel()
        {
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("===============");
                Console.WriteLine("1. Book a room");
                Console.WriteLine("2. Vacate a room");
                Console.WriteLine("3. Display ALL room details");
                Console.WriteLine("4. Vacate ALL rooms");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    BookRoom();
                }
                else if(choice == "2")
                {
                    VacateOneRoom();
                }
                else if (choice == "3")
                {
                    ShowAllRooms();
                }
                else if(choice == "4")
                {
                    VacateAll();
                }
            } while (choice == "");
        }

        /// <summary>
        /// This method will allow the user to book a room 
        /// </summary>
        public static void BookRoom()
        {
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("=================");
            Console.WriteLine("Book a room");

            Console.Write("Enter the room number: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many guests: ");
            numberOfGuests = Convert.ToInt32(Console.ReadLine());
            rooms[roomNumber] = numberOfGuests; //Make the booking

            Console.WriteLine("Room " + roomNumber + " booked for " + numberOfGuests);
        }
        
        /// <summary>
        /// This method will show all rooms and the correspondent number of guests
        /// </summary>
        public static void ShowAllRooms()
        {
            for (int i = 0; i < MAX; i++)
            {
                rooms[i] = UserLib.GetInt("Enter room number > ");
                guests[i] = UserLib.GetInt("Enter the number of guests " + " > ");
            }

            Console.WriteLine();
            Console.WriteLine("Bates Motel Room");
            Console.WriteLine("===================");

            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Room " + rooms[i] + "\t\t" + guests[i] + "guests");
            }
        }

        /// <summary>
        /// This method will vacate the room the user chooses
        /// </summary>
        public static void VacateOneRoom()
        {
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("=================");
            Console.WriteLine("Vacate one room");

            Console.Write("Enter the room number: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter zero: ");
            numberOfGuests = Convert.ToInt32(Console.ReadLine());
            rooms[roomNumber] = numberOfGuests;

            Console.WriteLine("Room " + roomNumber + " it has been vacated! ");
        }

        /// <summary>
        /// This method will vacate all rooms
        /// </summary>
        public static void VacateAll()
        {
            Array.Clear(rooms, 0, rooms.Length);

            Console.WriteLine("All rooms have been vacated!");
        }
    }//End of Motel class
}