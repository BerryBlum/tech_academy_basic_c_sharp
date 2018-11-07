using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Inheritance_124
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> Roster = new List<string>() { "Boss" };
            IQuittable quit = new Employee(); //
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates the employee class with both inherited proeprties

            employee.SayName(); //performs the SayName() function on the instantiated employee class to print out both values of FirstName and LastName.
            Roster.Add("Sample Student");
            Roster.ForEach(Console.WriteLine);
            int employee_index = Roster.IndexOf("Sample Student"); //assigns the index of my sample student employee to a variable
            Console.WriteLine("\nPlease type in 1"); //prompts user to run the employee.Quit() Method
            try
            {
                int user_choice = Convert.ToInt32(Console.ReadLine()); //converst input string to int
                if (user_choice == 1)
                {
                    employee.Quit(); //calls on method of name Quit with parameter type string
                    employee.Quit(employee_index); //calls on method by same name with parameter type int to update roster after employee quit
                    Roster.RemoveAt(employee_index);
                    Roster.ForEach(Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("did not type 1");
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
