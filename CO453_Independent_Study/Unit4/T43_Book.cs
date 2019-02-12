using System;

namespace CO453_Independent_Study.Unit4
{
    /// <summary>
    /// Author: Ana Zorro, ID 21903356
    /// BNU Foundation Degree in Computing
    /// CO453 Unit 4: Task 4.3
    /// 01/02/2018
    /// 
    /// This class will create a constructor for the Book class
    /// and in the Main() method will allow the user to choose 
    /// the values or to use the defaults
    /// </summary>
    class T43_Book
    {
        //Defines public string variables
        public static string author;
        public static string name, town, animal, weapon, job;

        //Constructor method to initialise variables
        public T43_Book()
        {
            author = "Ana";
            name = "Sarah";
            town = "Aylesbury";
            animal = "dog";
            weapon = "sword";
            job = "software developer";
        }

        //The program executes here
        private static void Main(String[] arg)
        {
            UserLib.WriteTitle("Book");

            //Allows the user to choose either to enter values or to use the defauls
            string answer;
            Console.Write("Do you prefer to enter values or to use the defaults? ");
            answer = Console.ReadLine();

            T43_Book myBook = new T43_Book(); //A new Book object

            if (answer == "values")
            {
                myBook.getDetails();    //Calls getDetails() method
                myBook.writeChapter1(); //Calls writeChapter1() method
            }
            else if (answer == "defaults")
            {
                myBook.writeChapter1(); //Calls writeChapter1() method
            }

            Console.ReadKey();
        }

        //Uses prompt to ask for information
        public static string ask(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }

        //Keeps using ask() to get information
        public void getDetails()
        {
            Console.WriteLine("\n");
            author = ask("Please type your name: ");
            name = ask("Please type a friend's name: ");
            town = ask("Now give me the name of a town: ");
            animal = ask("Now a type of animal: ");
            job = ask("Now a type of job: ");
            weapon = ask("And your weapon of choice: ");
        }

        //Writes chapter using information gathered
        public void writeChapter1()
        {
            Console.Clear();
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("=======================================");
            Console.WriteLine("It was a dark night in " + town + " and " + name + " could hear " + animal + "s screaming in the distance. ");
            Console.WriteLine(name + " staggered terrified through the streets of " + town + ", realising he had been followed. ");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + ".");
        }
    } //End of the T43_Book class
}