using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Loops
{
    class Program
    {
        static void Main() //Boolean comparison for both do while and while loops!
        {
            Console.WriteLine("Please tell me how many bananas there are!");
            int bananas = Convert.ToInt32(Console.ReadLine());
            
            while (bananas > 0)
            {
                if (bananas == 1)
                {
                    Console.WriteLine(bananas + " is left, ONE MOAR TO EAT I BELIEVE IN YOU!!!");
                    bananas--;
                }
                else
                {
                    Console.WriteLine(bananas + " are left! Eat moar!!");
                    bananas--;
                }
                
            }
            if (bananas == 0)
            {
                Console.WriteLine("It's a sad day when there are no bananas.");
            }
            
            Console.ReadLine();
            Console.WriteLine("Okay, how many bananas were there really?");
            bananas = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (bananas)
                {
                    case 1:
                        Console.WriteLine(bananas + " is left...the last banana.");
                        bananas--;
                        break;
                    case 0:
                        Console.WriteLine("Don't lie about the presence of baanas! If there were none to begin with you should just say that!");
                        break;
                    default:
                        Console.WriteLine(bananas + " are left, you should eat some more. Potassium for days!");
                        bananas--;
                        break;
                }
            } while (bananas > 0);
            Console.WriteLine("It's a sad day when there are no bananas.");
            Console.ReadLine();

        }
    }
}
