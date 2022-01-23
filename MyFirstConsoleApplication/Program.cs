using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        private static void GetUserNameAndLocation()
        {
            Person person = new Person();
            // prompt for the name
            Console.WriteLine("What is your name? ");
            person.name = Console.ReadLine();

            // prompt for the user's location
            Console.WriteLine($"Hi {person.name}! Where are you from? ");
            person.location = Console.ReadLine();

            Console.WriteLine($"I have never been to {person.location}.I bet it is nice.Press any key to continue...");
            Console.ReadKey();
        }
        private static void ChristmasCountdown(DateTime date)
        {
            // showing today's date
            Console.WriteLine($"Today's date is: {DateTime.Now.ToString("MM/dd/yyyy")}");

            // calculate days before christmas
            var daysTillChristmas = ( DateTime.Parse("2022/12/25")- date).Days;

            // display days before christmas
            Console.WriteLine($"There are {daysTillChristmas} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
