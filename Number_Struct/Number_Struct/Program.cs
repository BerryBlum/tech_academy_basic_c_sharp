using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 1234563753.12M }; //creates a struct called number with an Amount of whatever i put there
            Console.WriteLine(number.Amount); //Prints that amount as a decimal because M designator
            Console.ReadLine(); //system pause
        }
    }
}
