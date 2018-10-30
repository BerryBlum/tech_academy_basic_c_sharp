using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHAT IS YOUR FAVORITE NUMBUH??");
            int fav_num = Convert.ToInt32(Console.ReadLine());

            string result = fav_num == 7 ? "Good person or android depending on when this is being accessed...." : "Lucky numbuh 7 man, should change it to 7";

            Console.WriteLine(result);
            //int room_temperaure = 70;
            //Console.WriteLine("WHAT IS YOUR NAME");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi," + name + ", what is your current temperature?");
            //int current_temperature = Convert.ToInt32(Console.ReadLine());

            //if(current_temperature == room_temperaure)
            //{
            //    Console.WriteLine("Same temps yo");
            //}
            //else if (current_temperature > room_temperaure)
            //{
            //    Console.WriteLine("IT HOT OUT FOO");
            //}
            //else if (room_temperaure > current_temperature)
            //{
            //    Console.WriteLine("IT COLD ISH BRUH");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}
            Console.ReadLine();
            //int current_temperature = 80;
            //int room_temperature = 70;

            //string compare_results = current_temperature == room_temperature ? "Not the same temps" : "The same temps";
        }
    }
}
