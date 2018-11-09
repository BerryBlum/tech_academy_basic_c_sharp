using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Exercise
{
    public class Employee<T> //public class of employee
    {
        public List<T> Things_Parent { get; set; } //property of Employee to have a list of generic type

        public Employee() //Instantiates Things_Parents as a new List to acept assignment from main method
        {
            Things_Parent = new List<T>();
        }
    }
}


