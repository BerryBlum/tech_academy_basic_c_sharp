using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!!!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool is_guessed = number ==7 ;


            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 63, Try again!");
                        Console.WriteLine("Guess a number!!!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29, Try again!");
                        Console.WriteLine("Guess a number!!!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, Try again!");
                        Console.WriteLine("Guess a number!!!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7! Good job!");
                        Console.WriteLine("Guess a number!!!");
                        number = Convert.ToInt32(Console.ReadLine());
                        is_guessed = number == 7;
                        break;
                    default:
                        Console.WriteLine("WRONG");
                        Console.WriteLine("Guess a number!!!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!is_guessed);




            //switch(number)
            //{
            //    case 62:
            //        Console.WriteLine("You guessed 63, Try again!");
            //        break;
            //    case 29:
            //        Console.WriteLine("You guessed 29, Try again!");
            //        break;
            //    case 55:
            //        Console.WriteLine("You guessed 55, Try again!");
            //        break;
            //    case 7:
            //        Console.WriteLine("You guessed 7! Good job!");
            //        is_guessed = true;
            //        break;
            //    default:
            //        Console.WriteLine("WRONG");
            //        break;
            //}
            Console.ReadLine();
        }
    }
}
