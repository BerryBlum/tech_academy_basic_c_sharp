using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice_113
{
    class Void_Method
    {
        public static void Custom_Method(int int_one, int int_two)
        {
            int result = int_one * 6;
            Console.WriteLine(int_one + " is being multiplied by 6 which equals " + result);
            Console.WriteLine("The second number given is: " + int_two);
            return;
        }
    }
}
