using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritance_124
{
    public class Employee : Person, IQuittable //inherits the properties of the person class
    {

        public override void SayName() //takes the function that was defined in the person class and adds code to make it work how the employee class needs
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit() //quit method that prints out quit message
        {
            Console.WriteLine("I quit");
        }
        public void Quit(int index) //updates and prints new roster after employee leaves
        {
            Console.WriteLine("The number of employees who have quit today is: " + index);
        }
    }
}
