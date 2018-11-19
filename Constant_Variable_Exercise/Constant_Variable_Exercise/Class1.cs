using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Variable_Exercise
{
    public class Class1
    {
        public void Fruits()
        {
            const string constant = "Banana"; //only ever bananas
            Console.WriteLine("What is the color of a fruit?"); //user color, possibly odd
            try
            {
                string fruit_color = Console.ReadLine(); //sets color
                Fruits Fruits = new Fruits(fruit_color, constant); //creates a new fruit with given varaibles
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
