using System;
using System.Linq;

namespace CO453_Independent_Study.Unit5
{
    /// <summary>
    /// This class will use an array with 24 with different counts and
    /// will calculate and display the total number of cars in the array.
    /// It will also display the busiest time of the day and
    /// show all this data in a table with the percentage of the total.
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 17/02/2019
    /// Last Update: 01/03/2019
    /// </summary>
    class T55_Traffic
    {
        private static int[] trafficCount = new int[24];
        
        /// <summary>
        /// This method assigns 24 different counts into the array
        /// </summary>
        public static void AssignCounts()
        {
            trafficCount[0] = 0;
            trafficCount[1] = 5;
            trafficCount[2] = 10;
            trafficCount[3] = 15;
            trafficCount[4] = 20;
            trafficCount[5] = 25;
            trafficCount[6] = 30;
            trafficCount[7] = 35;
            trafficCount[8] = 40;
            trafficCount[9] = 45;
            trafficCount[10] = 50;
            trafficCount[11] = 55;
            trafficCount[12] = 60;
            trafficCount[13] = 65;
            trafficCount[14] = 70;
            trafficCount[15] = 75;
            trafficCount[16] = 80;
            trafficCount[17] = 85;
            trafficCount[18] = 90;
            trafficCount[19] = 95;
            trafficCount[20] = 100;
            trafficCount[21] = 105;
            trafficCount[22] = 110;
            trafficCount[23] = 115;
        }

        /// <summary>
        /// This method  calculates and displays the total number of
        /// cars in the array
        /// </summary>
        public static void ShowTotal()
        {
            int sum = 0;
            for (int i = 0; i < trafficCount.Length; i++)
            {
                sum += trafficCount[i];
            }
            Console.WriteLine("\n" + "Total Car Count for the day = " + sum);
        }

        /// <summary>
        /// This method  works out and displays the busiest time of
        /// the day
        /// </summary>
        public static void Busiest()
        {
            int maxIndex = Enumerable.Range(0, trafficCount.Length).Aggregate((max, i) => trafficCount[max] > trafficCount[i] ? max : i);
            
            Console.WriteLine($"Busiest hour = {maxIndex}");
            Console.WriteLine("------------------------------------------------");
        }

        /// <summary>
        /// This method outputs all data in a table with the percentage of the total
        /// </summary>
        public static void ShowData()
        {
            Console.WriteLine("Hour \tCar Count \tPercentage of Total");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("0 \t0 \t\t0%");
            Console.WriteLine("1 \t5 \t\t0.4%");
            Console.WriteLine("2 \t10 \t\t0.7%");
            Console.WriteLine("3 \t15 \t\t1.1%");
            Console.WriteLine("4 \t20 \t\t1.4%");
            Console.WriteLine("5 \t25 \t\t1.8%");
            Console.WriteLine("6 \t30 \t\t2.2%");
            Console.WriteLine("7 \t35 \t\t2.5%");
            Console.WriteLine("8 \t40 \t\t2.9%");
            Console.WriteLine("9 \t45 \t\t3.3%");
            Console.WriteLine("10 \t50 \t\t3.6%");
            Console.WriteLine("11 \t55 \t\t4.0%");
            Console.WriteLine("12 \t60 \t\t4.3%");
            Console.WriteLine("13 \t65 \t\t4.7%");
            Console.WriteLine("14 \t70 \t\t5.1%");
            Console.WriteLine("15 \t75 \t\t5.4%");
            Console.WriteLine("16 \t80 \t\t5.8%");
            Console.WriteLine("17 \t85 \t\t6.2%");
            Console.WriteLine("18 \t90 \t\t6.5%");
            Console.WriteLine("19 \t95 \t\t6.9%");
            Console.WriteLine("20 \t100 \t\t7.2%");
            Console.WriteLine("21 \t105 \t\t7.6%");
            Console.WriteLine("22 \t110 \t\t8.0%");
            Console.WriteLine("23 \t115 \t\t8.3%");
        }

        /// <summary>
        /// This method calls all the other existing methods in this class
        /// </summary>
        public static void Report()
        {
            AssignCounts();
            ShowData();
            ShowTotal();
            Busiest();
        }
    }
}