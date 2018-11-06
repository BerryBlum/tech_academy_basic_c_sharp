using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritance_124
{
    public class Employee : Person //inherits the properties of the person class
    {
        public override void SayName() //takes the function that was defined in the person class and adds code to make it work how the employee class needs
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
