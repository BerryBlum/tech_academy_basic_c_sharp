using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //to incude streamwrite/read

namespace Write_File_Fetch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number");
            int user_num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Myuri\Logs\log.txt", true)) //writes to my file
            {
                file.WriteLine(user_num); //writing the user input
            }
            using (StreamReader file = new StreamReader(@"C:\Users\Myuri\Logs\log.txt", true)) //reads from the written file
            {
                string file_num = file.ReadToEnd(); //reading the written user input
                Console.WriteLine(file_num); //print to console
            }
            Console.ReadLine();
        }
    }
}
