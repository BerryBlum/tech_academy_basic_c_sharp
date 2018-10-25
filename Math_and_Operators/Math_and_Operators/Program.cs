using System;

namespace Math_and_Operators
{
    class Program
    {
        static void Main()
        {
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combinedTotal = total + otherTotal;
            Console.WriteLine("Five plus ten = " + total.ToString());
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus five = " + difference);
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine("Ten time five = " + difference);
            Console.ReadLine();

            double quotient = 100.0 / 17.0;
            Console.WriteLine(quotient);
            Console.ReadLine();

            double remainder = 11 % 4;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 > 25;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int temperatureRoom = 70;
            int currentTemp = 72;

            bool isWarm = (temperatureRoom != currentTemp);
            Console.WriteLine(isWarm.ToString());
            Console.Read();
        }
    }
}
