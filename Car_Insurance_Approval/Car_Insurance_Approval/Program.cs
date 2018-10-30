using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string user_age = Console.ReadLine();
            int user_age_int = Convert.ToInt16(user_age);
            Console.WriteLine("True or false, you have had a DUI.");
            bool dui_check = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Have you had any speeding tickets? If so, how many?");
            string speeding_tickets = Console.ReadLine();
            int speeding_ticket_int = Convert.ToInt16(speeding_tickets);
            Console.WriteLine("Are you qualified for car insurance?");
            if((user_age_int > 15) && (dui_check == false) && (speeding_ticket_int <= 3))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }   
    }
}
