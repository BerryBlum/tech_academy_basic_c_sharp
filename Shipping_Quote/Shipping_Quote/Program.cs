using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");
            Console.WriteLine("What is the packages weight?");
            int package_weight = Convert.ToInt32(Console.ReadLine());
            if (package_weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What is the width of the package? In inches:");
            int package_width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package? In inches:");
            int package_height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package? In inches:");
            int package_length = Convert.ToInt32(Console.ReadLine());
            int package_dimensions = package_height + package_length + package_width;

            if (package_dimensions > 50)
            {
                Console.WriteLine("Your package is too big too be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                return;
            }
            decimal shipping = (((decimal)package_dimensions * (decimal)package_weight) / 100);
            Console.WriteLine("Your estimated total for shipping is: $" + shipping);
            Console.WriteLine("Thank you.");
            Console.ReadLine();


        }
    }
}
