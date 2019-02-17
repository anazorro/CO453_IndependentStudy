using System;
using CO453_Independent_Study.Unit5;

namespace CO453_Independent_Study
{
    public static class Program
    {
        /// <summary>
        /// The program executes here. This class will call the
        /// methods in the right order and get the sorting to work.
        /// Author: Ana Zorro, ID: 21903356
        /// Started: 15/02/2019
        /// Last Update:17/02/2019
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            T54_Bubble.InputNumbers();
            T54_Bubble.DisplayNumbers(new int[] { 0, 10, 110, -12, 1 });
            T54_Bubble.SortNumbers(new int[] { 0, 10, 110, -12, 1 });

            Console.ReadKey();
        }
    }
}