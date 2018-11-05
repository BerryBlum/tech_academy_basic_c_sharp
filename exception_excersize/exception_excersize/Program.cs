using System;
using System.Collections.Generic;

/// <summary>
/// Creates a list of integers. take in a user value and attempts to dive each integer in the list by the users value
/// provides exceptions for strings and 0
/// solution variable is an int so the answer will round down and not return values with decimal point values.
/// </summary>
namespace exception_excersize
{
    class Program
    {
        //system error, divide by zero when zero is entered by user.
        // system error, input was not in correct format when string is entered.
        static void Main(string[] args)
        {
            List<int> int_list = new List<int> { 9, 12, 34, 42, 100, 0 }; //initalize list of integers
            int count_num = 0; //init the count number to determine index of list
            int error_num = 0; //init if errors occur
            try
            {
                Console.WriteLine("Please tell me what integer you would like to divide this list of unknown numbers by: ");
                int user_number = Convert.ToInt32(Console.ReadLine()); //receives input for user number
                foreach (int element in int_list) //loops for each element in my list of integers
                {
                    int solution = int_list[count_num] / user_number; //solution variable to store solution
                    Console.WriteLine("The result of dividing " + int_list[count_num] + " by " + user_number + " is: " + solution);
                    count_num++; //increase index to look at
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + " Returning");
                error_num++;
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " Returning");
                error_num++;
                return;
            }
            finally
            {
                if (error_num == 0)
                {
                    Console.WriteLine("No errors were encountered.");
                    Console.ReadLine(); // pause statement after program runs
                }
                else
                {
                    Console.WriteLine("Errors were encountered, ending program.");
                    Console.ReadLine(); // pause statement after program runs
                }
            }
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}
