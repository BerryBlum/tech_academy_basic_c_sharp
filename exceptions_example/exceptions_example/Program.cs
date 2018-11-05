using System;

namespace exceptions_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number: ");
                int num_one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number: ");
                int num_two = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two numbers: ");
                int num_three = num_one / num_two;
                Console.WriteLine(num_one + " divided by " + num_two + " equals " + num_three);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
