using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_Employees_Lambda
{
    public class Employee<T> //generic class employee
    {
        public List<string> FName { get; set; }
        public List<string> LName { get; set; }
        public List<int> ID { get; set; }

        public Employee() //instantiate the employee so it has properties first name, last name and id
        {
            FName = new List<string>();
            LName = new List<string>();
            ID = new List<int>();
        }



        //public void Employee_Fname(string fname)
        //{
        //    FName.Add(fname);
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
