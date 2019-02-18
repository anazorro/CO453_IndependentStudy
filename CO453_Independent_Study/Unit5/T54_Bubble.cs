using System;

namespace CO453_Independent_Study.Unit5
{
    /// <summary>
    /// This class will sort numbers and words into order
    /// by using an algorithm called Bubble Sort
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 15/02/2019
    /// Last Update:17/02/2019
    /// </summary>
    class T54_Bubble
    {
        public static int z, j;
        public static string[] names = new string[5];

        /// <summary>
        /// This method will input five numbers into an array
        /// </summary>
        public static void InputNumbers()
        {
            int[] numbers = new int[5];

            numbers[0] = 0;
            numbers[1] = 10;
            numbers[2] = 110;
            numbers[3] = -12;
            numbers[4] = 1;
        }

        /// <summary>
        /// This method will clear the screen and display 
        /// all the numbers one above the other
        /// </summary>
        /// <param name="numbers"></param>
        public static void DisplayNumbers(int[] numbers)
        {
            Console.Clear();

            Console.WriteLine("Original array :");

            foreach (int i in numbers)
                Console.WriteLine(i);

            Console.WriteLine("\nPress Enter! ");

            Console.Read();
        }

        /// <summary>
        /// This method will apply the Bubble Sort algorithm 
        /// to sort the numbers into numerical order
        /// </summary>
        /// <param name="numbers"></param>
        public static void SortNumbers(int[] numbers)
        {
            int position;
            int length = numbers.Length - 2;

            for (int p = 0; p <= length; p++)
            {
                for (int i = 0; i <= length; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        position = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = position;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int i in numbers)
                Console.WriteLine(i);

            Console.Write("\n");
        }

        /// <summary>
        /// This method will input five names into an array
        /// </summary>
        public static void InputNames()
        {
            Console.WriteLine("Please enter 5 names ");

            for ( z = 0; z <= 4; ++z)
            {
                Console.Write("> ");
                names[z] = Console.ReadLine();
            }

            Console.Write("\n");
        }
        
        /// <summary>
        /// This method will clear the screen and display 
        /// all the names one above the other
        /// </summary>
        public static void DisplayNames()
        {
            Console.WriteLine("Original array :");

            for (z = 0; z <= 4; ++z)
            {
                Console.WriteLine(names[z]);
            }

            Console.Write("\n");
        }

        /// <summary>
        /// This method will apply the Bubble Sort algorithm 
        /// to sort the names into alphabetical order
        /// </summary>
        public static void SortNames()
        {
            string position;

            for (z = 0; z <= 4; ++z)
            {
                for (j = 0; j < 4; ++j)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        position = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = position;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");

            for (z = 0; z <= 4; ++z)
            {
                Console.WriteLine(names[z]);
            }

            Console.Write("\n");
        }
    }
}