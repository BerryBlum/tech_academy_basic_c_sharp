using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Practice using inherited features from different classes
/// </summary>
namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //init employee class with inherited properties from person class
            employee.SayName(); //calls function SayName() from Person class on the Employee class who is instanced in employee
            Console.ReadLine(); //system pause

        }
    }
}
