using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// instantiates a method from a different class and then asks for two inputs
/// converts the input strings to integers during the method calls
/// utilizes try catch for exception handling of code breaking issues
/// such as null value for first input or string / zero value for second value
/// </summary>
namespace Classes_and_Methods_115
{
    class Program
    {
        static void Main(string[] args)
        {
            int results = 0;
            Method method = new Method();
            Console.WriteLine("Please enter two integers one at a time, a second integer is not necessary, default value is 5.");
            try
            {
                string user_int_one = Console.ReadLine();
                string user_int_two = Console.ReadLine();
                if (user_int_two == string.Empty) //checks for empty second value and if true uses first call with only one input
                {
                    results = Method.User_Method(Convert.ToInt32(user_int_one));
                }
                else // if not blank pushes both values to called method unless aforementioned exceptions break it
                {
                    results = Method.User_Method(Convert.ToInt32(user_int_one), value_two: Convert.ToInt32(user_int_two));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " Program ending");
                Console.ReadLine();
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + " Program ending");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The value of the first number divided by the second number is " + results);
            Console.ReadLine();
        }
    }
}
