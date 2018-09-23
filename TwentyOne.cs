﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); //could also be written (deck, 3) naming the paremeters makes it easier to read

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }


            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //by adding the int times and assigning it a default value creates an optional parameter 
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }

                deck.Cards = TempList;
            }
           
            return deck;

        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i<times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}



    }

}
