using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritance_124
{
    public abstract class Person //creates parent class called person who has attributes first name and last name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName(); //creates a generic function that does not have its own code
    }
}
