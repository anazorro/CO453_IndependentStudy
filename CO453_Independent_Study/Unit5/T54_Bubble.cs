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

        }

        /// <summary>
        /// This method will clear the screen and display 
        /// all the names one above the other
        /// </summary>
        public static void DisplayNames()
        {
            Console.Clear();

            Console.WriteLine("Original array :");


        }

        /// <summary>
        /// This method will apply the Bubble Sort algorithm 
        /// to sort the names into alphabetical order
        /// </summary>
        public static void SortNames()
        {

        }
    }
}