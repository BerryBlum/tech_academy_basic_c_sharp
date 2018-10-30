using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Anonymous
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Porgram");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is hourly rate? As an integer");
            string person_1_rate = Console.ReadLine();
            decimal person_1_rate_int = Convert.ToDecimal(person_1_rate);
            Console.WriteLine("Hours worked per week, as an integer");
            string person_1_hours = Console.ReadLine();
            int person_1_hours_int = Convert.ToInt16(person_1_hours);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is hourly rate? As an integer");
            string person_2_rate = Console.ReadLine();
            decimal person_2_rate_int = Convert.ToDecimal(person_2_rate);
            Console.WriteLine("Hours worked per week, as an integer");
            string person_2_hours = Console.ReadLine();
            int person_2_hours_int = Convert.ToInt16(person_2_hours);

            Console.WriteLine("Annual Salary of Person 1:");
            decimal person_1_salary = person_1_rate_int * person_1_hours_int * 56;
            Console.WriteLine(person_1_salary);

            Console.WriteLine("Annual Salary of Person 2:");
            decimal person_2_salary = person_2_rate_int * person_2_hours_int * 56;
            Console.WriteLine(person_2_salary);

            Console.WriteLine("Does person 1 make more money than person 2?");
            if (person_1_salary > person_2_salary)
            {
                Console.WriteLine("True");
            }
            else if (person_2_salary == person_1_salary)
            {
                Console.WriteLine("They make the same amount.");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
            
        }
    }
}
