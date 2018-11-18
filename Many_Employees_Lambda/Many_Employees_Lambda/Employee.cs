using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_Employees_Lambda
{
    public class Employee //generic class employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public void Print_Employee()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Id);
        }

        //public void Employee_Fname(string fname)
        //{
        //    fname = emplyeee.FName
        //}
        //public void Employee_Lname(string lname)
        //{
        //    LName.Add(lname);
        //}
        //public void Employee_Id(int id)
        //{
        //    ID.Add(id);
        //}
    }
}
