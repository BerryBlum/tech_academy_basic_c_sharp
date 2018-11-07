using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_one = new Employee() { Employee_Id = 000000123 }; //instantiate three instances of employees, two of which
            Employee employee_two = new Employee() { Employee_Id = 000000124 }; //have the same employee id for comparison purposes
            Employee employee_three = new Employee() { Employee_Id = 000000123 };

            Console.WriteLine("Checking for equivalency between Employee one and threes IDs");
            if (Convert.ToBoolean(employee_one.Employee_Id == employee_three.Employee_Id)) //didn't think it would still require me to specify .Employee_Id by overloading my own == functionality
            {
                Console.WriteLine("Employee one's ID is " + employee_one.Employee_Id); //Leads me to believe i did not perform this task properly
                Console.WriteLine("Employee three's ID is " + employee_three.Employee_Id);
                Console.ReadLine();
            }
            Console.WriteLine("Checking for equivalency between Employee one and twos IDs");
            if (Convert.ToBoolean(employee_one.Employee_Id != employee_two.Employee_Id))
            {
                Console.WriteLine("Employee one's ID is " + employee_one.Employee_Id);
                Console.WriteLine("Employee two's ID is " + employee_two.Employee_Id);
                Console.ReadLine();
            }
        }
    }
}
