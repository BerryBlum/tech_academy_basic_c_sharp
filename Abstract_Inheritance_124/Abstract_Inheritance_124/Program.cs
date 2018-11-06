using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritance_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates the employee class with both inherited proeprties
            employee.SayName(); //performs the SayName() function on the instantiated employee class to print out both values of FirstName and LastName.
            Console.ReadLine(); //system pause
        }
    }
}
