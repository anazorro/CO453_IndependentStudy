using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_Independent_Study.Unit5
{
    class T54_Bubble
    {
        

        public static void InputNumbers()
        {
            int[] numbers = { 0, 1500, 200, -10, 3000, 750 };

            Console.Read();
        }

        public static void Display(int[] numbers)
        {
            Console.Clear();

            Console.WriteLine("Original array :");
            foreach (int aa in numbers)
                Console.Write(aa + " ");
        }

        public static void SortNumbers(int[] numbers)
        {
            int t;

            for (int p = 0; p <= numbers.Length - 2; p++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        t = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in numbers)
                Console.Write(aa + " ");
            Console.Write("\n");
        }
    }
}