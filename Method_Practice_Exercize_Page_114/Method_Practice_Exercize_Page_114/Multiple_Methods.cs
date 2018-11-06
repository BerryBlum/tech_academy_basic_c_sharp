using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Practice_Exercize_Page_114
{
    public class Multiple_Methods
    {
        public static int int_return(int user_int) //multiplication
        {
            int result = user_int * 4;
            return result;
        }

        public static int int_return(double user_int) //division
        {
            double result = user_int / 56;
            return (int) result;
        }

        public static int int_return(string user_string) //convert to string if possible and take remainder of 100 / user_number , else return 0
        {
            try
            {
                int result = 100 % Convert.ToInt32(user_string);
                return result;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message + "Defaulting to return 0");
                return 0;
            }
        }
    }
}
