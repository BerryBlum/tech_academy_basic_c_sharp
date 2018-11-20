using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class InvalidAException : Exception
    {
        public InvalidAException() //custom exception inherits properties of Exception
            :base () { }
        public InvalidAException(int age) //over writes to accept age as int
            : base(age.ToString()) { }
    }
}
