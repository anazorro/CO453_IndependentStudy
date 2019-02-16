using System;

namespace CO453_Independent_Study
{
    /// <summary>
    /// Author: Ana Zorro, ID 21903356
    /// BNU Foundation Degree in Computing
    /// CO453 Unit 4: Task 4.4
    /// 03/02/2018
    /// 
    /// This class will allow the ser to enter their weight and height
    /// and then calculate their BMI
    /// 
    /// In the Main() method will have a new BMI object and then display 
    /// the BMI value and message
    /// 
    /// Extra: Modify the program so that it can cope with either metric
    /// measurements (kg and metres) or imperial (pounds and inches)
    /// </summary>
    class T44_BMI
    {
        public static double weight, height;
        public static double BMI;
        public static string measurements;

        //The program executes here
        private static void Main(string[] arg)
        {
            UserLib.WriteTitle("BMI calculator");

            T44_BMI myBMI = new T44_BMI(); //A new BMI object

            myBMI.CalculatesInMetricOrImperial();

            Console.ReadKey();
        }

        //Gets the users weight and height in metric measurements by using the GetDouble() method
        public void GetMetricDetails()
        {
            weight = UserLib.GetDouble("Please enter your weight (in kgs) > ");
            height = UserLib.GetDouble("Please enter your height (in metres) > ");
        }

        //Gets the users weight and height in imperial measurements by using the GetDouble() method
        public void GetImperialDetails()
        {
            weight = UserLib.GetDouble("Please enter your weight (in pounds) > ");
            height = UserLib.GetDouble("Please enter your height (in inches) > ");
        }

        //Calculates the metric BMI by dividing the weight by the height to the power of two
        //Using Math.Pow
        public void CalcMetricBMI()
        {
            BMI = weight / Math.Pow(height, 2);
        }

        //Calculates the imperial BMI by dividing the weight * 703 by the height to the power of two
        //Using Math.Pow
        public void CalcImperialBMI()
        {
            BMI = weight * 703 / Math.Pow(height, 2);
        }

        //Displays the Body Mass Index metric value and a message
        public void DisplayBMIValueAndMessage()
        {
            if(BMI < 18.5)
            {
                Console.WriteLine("\nBMI = " + BMI.ToString("0.00") + "    Underweight");
            }
            else if(BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("\nBMI = " + BMI.ToString("0.00") + "    Desirable weight for size");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("\nBMI = " + BMI.ToString("0.00") + "    Overweight");
            }
            else if (BMI >= 30 && BMI < 40)
            {
                Console.WriteLine("\nBMI = " + BMI.ToString("0.00") + "    Obese");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("\nBMI = " + BMI.ToString("0.00") + "    Severely Obese");
            }
        }
        public void CalculatesInMetricOrImperial()
        {
            measurements = UserLib.GetString("Do you wish to calculate your BMI in metric or imperial measurements? ");
            if (measurements == "metric")
            {
                GetMetricDetails();
                CalcMetricBMI();
                DisplayBMIValueAndMessage();
            }
            else if (measurements == "imperial")
            {
                GetImperialDetails();
                CalcImperialBMI();
                DisplayBMIValueAndMessage();
            }
        }
    }//End of the T44_BMI class
}