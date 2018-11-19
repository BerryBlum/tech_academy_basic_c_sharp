using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Constant_Variable_Exercise
{
    public class Fruits //class of fruits
    {
        public Fruits(string color) : this(color, "Banana") //generic fruit name is banana with any given color input
        {
        }
        public Fruits(string color, string name) //if given a name constant of banana is always passed in anyways muahahaahahahaha
        {
            var edible = "not"; //for some reason i made bananas not edible
            Color = color; //color is user color
            Name = name; //name banana
            Console.WriteLine("The {0} has a color of {1} and it is {2} edible", Name, Color, edible); //tells user the possibly odd colored banana is not edible
        }

        public string Color { get; set; } //fruit properties
        public string Name { get; set; }
    }
}
