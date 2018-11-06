using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class Deck
    {
        

        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string> { "Clubs", "Hearts", "Diamonds", "Spades" }; //creates list of Suit
            List<string> Faces = new List<string>() //creates a list of cards face values
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach ( string face in Faces ) //for each suit, combine with each face value
            {
                foreach (string suit in Suits )
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> temp_list = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int random_index = random.Next(0, Cards.Count);
                    temp_list.Add(Cards[random_index]);
                    Cards.RemoveAt(random_index);
                }
                this.Cards = temp_list;
            }
        }

    }


}
