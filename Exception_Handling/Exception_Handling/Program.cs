using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?"); //asks age
                int user_age = Convert.ToInt32(Console.ReadLine()); //converts to int
                if (user_age <= 0) throw new InvalidAException(); //if statement to throw new catch // does not check for multiple errors in one statement
                int current_year = DateTime.Now.Year;
                int birthYear = current_year - user_age;
                
                Console.WriteLine("Born in {0}, you are {1} years old!", birthYear, user_age);
                Console.ReadLine();
            }
            catch(InvalidAException) //custom catch for 0 and negative values
            {
                Console.WriteLine("You entered an inpossible age.");
                Console.ReadLine();
                return;
            }
            catch(Exception ex) //generic exception
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine(); //general message
                return;
            }

        }
    }
}
