using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_Exercise
{
    class Employee
    {
        public int Employee_Id { get; set; } //sets employee property of having an ID

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Employee operator == (Employee employee_one, Employee employee_two) //overwrites the == operator to take in two instances of employees and compare their ID's
        {
            employee_one.Employee_Id.CompareTo(employee_two.Employee_Id);
            return employee_one;
        }
        public static Employee operator != (Employee employee_one, Employee employee_two) //overwrites !=
        {
            employee_one.Employee_Id.CompareTo(employee_two.Employee_Id);
            return employee_one;
        }
    }
}
