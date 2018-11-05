using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Practice
{
    public class Math
    {
        public static int Modulus(int user_int) //remainder
        {
            Console.WriteLine("Performing remainder calculation when " + user_int + " is divided by 3");
            int operation_result = user_int % 3;
            return operation_result;
        }

        public static int Division(int user_int) //division returns whole number
        {
            Console.WriteLine("Performing division calculation when " + user_int + " is divided by 3");
            int operation_result = user_int / 3;
            return operation_result;
        }

        public static int Multiply(int user_int) // multiply
        {
            Console.WriteLine("Performing multiplication calculation when " + user_int + " is multiplied by 3");
            int operation_result = user_int * 3;
            return operation_result;
        }
    }
}
