using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Person //class to inherit properties from
    {
        public string FirstName { get; set; } //property one
        public string LastName { get; set; } //property two

        public void SayName() // writes both properties to console
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
