using System;
using CO453_Independent_Study.Unit4;
using CO453_Independent_Study.Unit5;

namespace CO453_Independent_Study
{
    class Program
    {

        public static void Main(int[] numbers)
        {
            T54_Bubble.InputNumbers();
            T54_Bubble.Display(numbers);
            T54_Bubble.SortNumbers(numbers);

            Console.ReadKey();
        }
    }
}