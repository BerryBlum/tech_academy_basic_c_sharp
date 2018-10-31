using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "michael";
            string quote = "The man said, \" Well, that's not gone well\" \nThis man of course was CLARKSON!";
            Console.WriteLine(quote);
            Console.ReadLine();

            bool true_or_false = name.Contains("e");
            true_or_false = name.EndsWith("e");

            int length = name.Length;

            name = name.ToLower();
            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Michael");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
