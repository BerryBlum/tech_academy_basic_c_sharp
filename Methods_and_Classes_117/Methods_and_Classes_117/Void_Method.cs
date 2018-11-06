using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Not 100% certain I got the usage of static method correct. As i understand it is that it loads the function into memory 
/// for ease of access without needing to be initialized in the main function.
/// </summary>
namespace Methods_and_Classes_117
{
    class Void_Method
    {
        public void User_Method(int user_input)
        {
            double user_value = Convert.ToDouble(user_input) / 2; //converts answer to type double
            Console.WriteLine("Your number divided by 2 is " + user_value); // results of division operation
        }
        public static void User_Method(out string error_message, out string is_null) //overload method to input text in case of code breaks
        {
            error_message = " Program ending.";
            is_null = null;
        }
    }
}
