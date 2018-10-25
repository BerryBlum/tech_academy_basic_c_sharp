using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program that asks your name and prints it back out
            /Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favaorite number?");
            string favoriteNumber = Console.ReadLine();
            Convert.ToInt16(favoriteNumber);
            Console.WriteLine(favoriteNumber);

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            Console.WriteLine(questionMark);

            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.134357;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -234;
            string myName = "BBBBEEEEERRRRRRRYYYYY";

            int currentAge = 24;
            string yearsOld = currentAge.ToString();
            Console.WriteLine(yearsOld);

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.Read();
        }
    }
}
