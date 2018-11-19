using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Variable_Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the color of a fruit?"); //asks for fruit color
            string user_color = Console.ReadLine(); //sets color
            const string fruit = "Banana"; //sets fruit as banana because it's always banana even if it's an avocado *Sp and lazy...
            try
            {
                Fruits fruits = new Fruits(user_color, fruit); //creates fruit with properties passed in
            }
            catch(FormatException ex) //catches if input was not a string type
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fruit is always banana and we do not eat the banana, we worship it. No heretics alllowed, wait what?");
            Console.Read(); //sys pause
        }
    }
}
