using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_115
{
    class Method
    {
        public static int User_Method(int value_one, int value_two = 5) //division computation using values from the main method with a second value defaulting to 5
        {
            int results = value_one / value_two;
            return results;
        }
    }
}
