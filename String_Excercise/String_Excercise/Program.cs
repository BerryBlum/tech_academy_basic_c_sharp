using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Excercise
{
    class Program
    {
        static void Main() //Creates a concatenated string, turns it into an uppercase statement and then creates a mini paragraph with it.
        {
            string pineapples_0 = "Pineapples ";
            string pineapples_1 = "are ";
            string pineapples_2 = "good!";
            string statement = pineapples_0 + pineapples_1 + pineapples_2;
            Console.WriteLine(statement);
            statement = statement.ToUpper();
            Console.WriteLine(statement);

            StringBuilder string_builder = new StringBuilder();

            string_builder.Append(statement);
            string_builder.Append(" Coconuts are good!");
            string_builder.Append(" A pina colada must be the best drink in existence!!!");
            Console.Write(string_builder);
            Console.ReadLine();
        }
    }
}
