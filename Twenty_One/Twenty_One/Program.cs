using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            int times_shuffled = 0;
            deck = Shuffle(deck, out times_shuffled, 3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", times_shuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int times_shuffled, int times = 1)
        {
            times_shuffled = 0;
            for(int i = 0; i < times; i++)
            {
                times_shuffled++;
                List<Card> temp_list = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int random_index = random.Next(0, deck.Cards.Count);
                    temp_list.Add(deck.Cards[random_index]);
                    deck.Cards.RemoveAt(random_index);
                }
                deck.Cards = temp_list;
            }
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
