using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace DateTime_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now; //sets datetime to current time from computer
            Console.WriteLine("It is currently {0}", dateTime); //prints current time
            Console.WriteLine("Please input a number as an integer: "); //asks for integer
            try
            {
                string user_input = Console.ReadLine(); //receives input
                DateTime futureTime = dateTime.AddHours(int.Parse(user_input));
                Console.WriteLine("It will be {0} in {1} Hours", futureTime, user_input);
                string target = @"\Users\Myuri\Downloads\logs.txt"; //logs to personal downloads file labeled logs.txt
                using (StreamWriter file = new StreamWriter(target, true))
                {
                    file.WriteLine("Current Date and Time: {0}", dateTime);
                    file.WriteLine("Future Date and Time: {0}", futureTime);
                }
            }
            catch (FormatException ex) //string input as non int
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) //thrown if logs cannot be written to
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
