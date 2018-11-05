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
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> temp_list = new List<Card>();
            Random random = new Random();
            while (deck.Cards.Count > 0)
            {
                int random_index = random.Next(0, deck.Cards.Count);
                temp_list.Add(deck.Cards[random_index]);
                deck.Cards.RemoveAt(random_index);
            }
            deck.Cards = temp_list;
            return deck;
        }
    }
}
