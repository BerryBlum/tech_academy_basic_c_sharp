using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in the current day of the week(Please capitalize): "); //prompts the user for day of the week requesting proper syntax
            bool attempt = true; //initialize an attempt variable for the do loop
            do
            { 
                try //try to match user input to set list of days of the week
                {
                    string user_day = Console.ReadLine(); //variable to receive user input
                    DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), user_day); //comapres to DaysOfTheWeek enum
                    attempt = true; //gotta exit the loop after proper entry after failed entry...
                }
                catch (ArgumentException ex) //if not in the list spits out error type, sets attempt to false to loop back through and prompts user for valid input
                {
                    Console.WriteLine(ex.Message);
                    attempt = false;
                    Console.WriteLine("Please input a valid day of the week: ");
                }
            } while (attempt == false);
            Console.WriteLine("Yay that's a day of the week!"); //definitely not checking to make sure the user actually put in the actual day of the week, just a day of the week
            Console.ReadLine(); //system pause

        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
