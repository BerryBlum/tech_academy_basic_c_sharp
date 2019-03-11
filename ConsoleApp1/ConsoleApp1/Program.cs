using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9119;
            string y = x.ToString();
            char[] array = y.ToCharArray();
            string result = "";
            foreach (char c in array)
            {
                int z = Convert.ToInt32(c) - 48;
                result += (Math.Pow(z, 2)).ToString();
            }

            int final = Convert.ToInt32(result);
            Console.WriteLine(final);
            Console.ReadLine();
        }
    }
}
