using System;
using Casino;
using Casino.Interfaces;
using System.IO;


namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Highway Robbery Casino and Bar";

            Console.WriteLine("Welcome to the {0}!", casinoName);
            Console.WriteLine("What is your name?");
            string player_name = Console.ReadLine();


            bool validAnswer = false;
            int player_funds = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money do you want to play with?");
                validAnswer = int.TryParse(Console.ReadLine(), out player_funds);
                if (!validAnswer)
                {
                    Console.WriteLine("Please insert digits only, no decimals");
                }
            }





            Console.WriteLine("Hello, {0}. Would you like to play?", player_name);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(player_name, player_funds);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Myuri\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player_funds > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Calling security on your stupid butt!");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occured, please contact your system admin.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to play other games or drink in our bar!");
            Console.Read();
        }
    }
}
