using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Asks user for a number to perform maths on
/// Calls multiple methods to perform each task
/// Uses try / catch in case of user input error
/// Only returns whole numbers, rounds down
/// </summary>
namespace Methods_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number would you like to see various results of mathematical operations on?");
                int user_int = Convert.ToInt32(Console.ReadLine());

                int operation_result = Math.Modulus(user_int);
                Console.WriteLine(operation_result);

                int operation_result_two = Math.Division(user_int);
                Console.WriteLine(operation_result_two);

                int operation_result_three = Math.Multiply(user_int);
                Console.WriteLine(operation_result_three);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Programming ending");
                Console.ReadLine();
            }
        }
    }
}
