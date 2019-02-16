using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_Independent_Study.Unit5
{
    class T56_Motel
    {
        int[] rooms; //Define an integer array called rooms
        const int MAX = 21;

        public static void Main() //Program starts executing here
        {
            T56_Motel BatesMotel = new T56_Motel(); //Create new object BatesMotel

            BatesMotel.RunMotel(); //Call its runMotel
        }

        public T56_Motel() //Contructor
        {
            rooms = new int[MAX]; //Allow room numbers from 1 to 5
        }

        public void RunMotel()
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
            } while (choice == ""); //tive de adicionar isto
        }

        public void BookRoom()
        {
            int roomNumber, guests;
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("=================");
            Console.WriteLine("Book a room");
            Console.WriteLine("Enter the room number: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many guests: ");
            guests = Convert.ToInt32(Console.ReadLine());
            rooms[roomNumber] = guests; //Make the booking
            Console.WriteLine("Room " + roomNumber + " booked for " + guests);
        }
    }//End of Motel class
}
