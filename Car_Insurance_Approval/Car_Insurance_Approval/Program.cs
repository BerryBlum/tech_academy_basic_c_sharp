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
            Console.WriteLine("Have you ever had a DUI? If so, how many?");
            string dui_check = Console.ReadLine();
            int dui_check_int = Convert.ToInt16(dui_check);
            Console.WriteLine("Have you had any speeding tickets? If so, how many?");
            string speeding_tickets = Console.ReadLine();
            int speeding_ticket_int = Convert.ToInt16(speeding_tickets);
            Console.WriteLine("Are you qualified for car insurance?");
            if((user_age_int > 15) && (dui_check_int == 0) && (speeding_ticket_int <= 3))
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
