using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> Things_String = new Employee<string>(); //instantiate a new item of name Things_String with property of list Things_Parent
            Employee<int> Things_Int = new Employee<int>(); //Instantiates a new item of name Things_Int with property of list from Things_Parent
            Things_String.Things_Parent.Add("Banana"); //adds things to both lists of proper types.
            Things_Int.Things_Parent.Add(42);
            Things_String.Things_Parent.Add("Banana");
            Things_Int.Things_Parent.Add(42);
            Things_String.Things_Parent.Add("Banana");
            Things_Int.Things_Parent.Add(42);
            Things_String.Things_Parent.Add("Banana");
            Things_Int.Things_Parent.Add(42);
            Things_String.Things_Parent.Add("Banana");
            Things_String.Things_Parent.Add("Banana");
            Things_Int.Things_Parent.Add(42);
            Things_Int.Things_Parent.Add(42);

            foreach(string Items in Things_String.Things_Parent) //loops through each list and prints out all values within
            {
                Console.WriteLine(Items);
            }
            foreach(int Items in Things_Int.Things_Parent) //foreach is blasphemous!!! easier but blasphemous
            {
                Console.WriteLine(Items);
            }
            Console.ReadLine();
        }
    }
}
