using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - dateTime;
            

            Console.WriteLine("Welcome to the 21 casino robbery, i mean game!");
            Console.WriteLine("What is your name?");
            string player_name = Console.ReadLine();

            Console.WriteLine("How much money do you want to play with?");
            int player_funds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to play?", player_name);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(player_name, player_funds);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player_funds > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to play other games or drink in our bar!");
            Console.Read();
        }
    }
}
