using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_Employees_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>(); //employee list
            List<Employee> new_list = new List<Employee>(); //new list

            employee.Add(new Employee() { FirstName = "Joe", LastName = "Schmo", Id = 1 });
            employee.Add(new Employee() { FirstName = "Joe", LastName = "Bloe", Id = 2 });
            employee.Add(new Employee() { FirstName = "Joe", LastName = "Jackson", Id = 3 });
            employee.Add(new Employee() { FirstName = "Holo", LastName = "WiseWolf", Id = 4 });
            employee.Add(new Employee() { FirstName = "Lawrence", LastName = "Craft", Id = 5 });
            employee.Add(new Employee() { FirstName = "Sarah", LastName = "Sai", Id = 6 });
            employee.Add(new Employee() { FirstName = "Blair", LastName = "Witch", Id = 8 });
            employee.Add(new Employee() { FirstName = "Henry", LastName = "Repeater", Id = 9 });
            employee.Add(new Employee() { FirstName = "Dean", LastName = "Not Moose", Id = 10 });


            foreach (Employee name in employee)
            {
                name.Print_Employee();
            }

            Console.Read();


            //List<string> lambda_list = employee.FName.Where( x => x == "Joe").ToList(); //where the value is "Joe", add that to a new list
            //List<int> Lambda_List_ID = employee.ID.Where(x => x > 5).ToList(); //Where id is greater than 5 add that to a list
            //lambda_list.ForEach(Console.WriteLine); //print statements to check operation
            //Lambda_List_ID.ForEach(Console.WriteLine);
            //new_list.FName.ForEach(Console.WriteLine);
            //Console.ReadLine();






        }
    }
}
