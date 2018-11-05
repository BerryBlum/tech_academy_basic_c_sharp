using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice_113
{
    class Program
    {
        static void Main(string[] args)
        {
            Void_Method.Custom_Method( 5, 6 ); //first instance of custom_method with generic values

            Console.WriteLine("Please give a first integer: ");
            int var_one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give a second integer: ");
            int var_two = Convert.ToInt32(Console.ReadLine());

            Void_Method.Custom_Method(var_one, var_two); //passing in two user numbers

            Void_Method.Custom_Method(int_one: var_one, int_two: var_two); //naming those user numbers how they are in the custom method

            Console.ReadLine();
        }
    }
}
