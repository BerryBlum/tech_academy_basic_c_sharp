﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty_One
{
    public class Card
    {
        public Suit Suit { get; set; } //allows Suit and Face values to be set
        public Face Face { get; set; }
    }
    public enum Suit// enums are like a class, good idea to keep one class per file but Suit relates directly to card
    {               //underlying value is int
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
