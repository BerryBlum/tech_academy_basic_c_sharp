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
            Employee<string> employee = new Employee<string>(); //employee list
            Employee<string> new_list = new Employee<string>(); //new list
            int index = 0; //counter
            employee.FName.Add("Joe"); //first names
            employee.FName.Add("Joe");
            employee.FName.Add("Joe");
            employee.FName.Add("Holo");
            employee.FName.Add("Lawrence");
            employee.FName.Add("Sarah");
            employee.FName.Add("Berry");
            employee.FName.Add("Blair");
            employee.FName.Add("Henry");
            employee.FName.Add("Dean");
            employee.LName.Add("Schmo"); //last names
            employee.LName.Add("Bloe");
            employee.LName.Add("Jackson");
            employee.LName.Add("WiseWolf");
            employee.LName.Add("Craft");
            employee.LName.Add("Sai");
            employee.LName.Add("Berry");
            employee.LName.Add("Witch");
            employee.LName.Add("Repeater");
            employee.LName.Add("Not Moose");
            employee.ID.Add(1); //ids
            employee.ID.Add(2);
            employee.ID.Add(3);
            employee.ID.Add(4);
            employee.ID.Add(5);
            employee.ID.Add(6);
            employee.ID.Add(7);
            employee.ID.Add(8);
            employee.ID.Add(9);
            employee.ID.Add(10);

            //did nto work like i wanted to
            //employee.Add(new Employee("Joe", "Schmo", 1));
            //employee.Add(new Employee("Joe", "Bloe", 2));
            //employee.Add(new Employee("Joe", "Jackson", 3));
            //employee.Add(new Employee("Holo", "WiseWolf", 4));
            //employee.Add(new Employee("Lawrence", "Craft", 5));
            //employee.Add(new Employee("Sarah", "Sai", 6));
            //employee.Add(new Employee("Berry", "Berry", 7));
            //employee.Add(new Employee("Blair", "Witch", 8));
            //employee.Add(new Employee("Henry", "Repeater", 9));
            //employee.Add(new Employee("Dean", "Not Moose", 10));

            foreach (string name in employee.FName)
            {
                if (name == "Joe")
                {
                    new_list.FName.Add(employee.FName[index]);
                    new_list.LName.Add(employee.LName[index]);
                    new_list.ID.Add(employee.ID[index]);

                }
                index++; //counts current index to match with name
            }

            List<string> lambda_list = employee.FName.Where( x => x == "Joe").ToList(); //where the value is "Joe", add that to a new list
            List<int> Lambda_List_ID = employee.ID.Where(x => x > 5).ToList(); //Where id is greater than 5 add that to a list
            lambda_list.ForEach(Console.WriteLine); //print statements to check operation
            Lambda_List_ID.ForEach(Console.WriteLine);
            new_list.FName.ForEach(Console.WriteLine);
            Console.ReadLine();






        }
    }
}
