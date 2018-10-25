using System;

namespace Daily_Report_Tech_Academy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Which course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page are you currently on?");
            string page = Console.ReadLine();
            int currentPage = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer with 'true' or 'false'.");
            string helpNeeded = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to offer? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursToday = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();

        }
    }
}
