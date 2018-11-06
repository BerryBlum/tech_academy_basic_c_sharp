using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Classes_117
{
    class Program
    {
        static void Main(string[] args)
        {
            Void_Method results = new Void_Method(); // init the class

            Console.WriteLine("Please input an integer you would like to divide by two:"); //ask for input and what will happen to it
            try
            {

                int user_input = Convert.ToInt32(Console.ReadLine()); //converts that input to type int
                results.User_Method(user_input); //calls the user_method of Void_Method class with the covnerted value
            }
            catch (FormatException ex)
            {
                Void_Method.User_Method(out string error_message, out string is_null); // makes the error_message value from user_method available
                Console.WriteLine(ex.Message + error_message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
