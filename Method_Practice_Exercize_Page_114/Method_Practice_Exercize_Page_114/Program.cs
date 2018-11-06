using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Method_Practice_Exercize_Page_114
{
    class Program
    {
        static void Main(string[] args) //not 100% certain on the instantiation of the class as it relates to the methods here
        {
            Multiple_Methods new_int = new Multiple_Methods(); //this should allow me to call "new_int.int_return()"
                                                               //because int_return is a method of Multiple_Methods right?
            int results = Multiple_Methods.int_return(5);
            Console.WriteLine(results);

            results = Multiple_Methods.int_return(900.432);
            Console.WriteLine(results);

            results = Multiple_Methods.int_return("12");
            Console.WriteLine(results);

            Console.ReadLine();
        }
    }
}
