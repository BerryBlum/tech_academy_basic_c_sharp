using System;

namespace Operators_Practice_Page_66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number as an integer");
            string userInput = Console.ReadLine();
            long userInput_Long = Convert.ToInt64(userInput);
            long outPut = userInput_Long * 50;
            Console.WriteLine("50 time the number you gave is: " + outPut);

            Console.WriteLine("Please input an integer");
            string userInput_2 = Console.ReadLine();
            int userInput_2_Int = Convert.ToInt32(userInput_2);
            int outPut_2 = userInput_2_Int + 25;
            Console.WriteLine("Your number plus 25 is: " + outPut_2);

            Console.WriteLine("Please input an integer");
            string userInput_3 = Console.ReadLine();
            double userInput_3_Double = Convert.ToDouble(userInput_3);
            double outPut_3 = userInput_3_Double / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + outPut_3);

            Console.WriteLine("Please input an integer");
            string userInput_4 = Console.ReadLine();
            int userInput_4_Int = Convert.ToInt32(userInput_4);
            bool outPut_4 = userInput_4_Int > 50;
            Console.WriteLine("Is your number greater than 50? " + outPut_4);

            Console.WriteLine("Please input an integer");
            string userInput_5 = Console.ReadLine();
            int userInput_5_Int = Convert.ToInt32(userInput_5);
            int outPut_5 = userInput_5_Int % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + outPut_5);

            Console.Read();
        }
    }
}
