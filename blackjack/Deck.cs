using System;
using System.Collections.Generic;

namespace blackJack
{

 public class Deck
    {
        public Random rand = new Random();
        List<Card> contents = new List<Card>();
        public Deck()
        {
            this.Reset();
        }
         public void Shuffle(int reps = 3)
         {
            for(int p = reps; p>0; p--)
            {
                int size = this.contents.Count;
                for(int i=0; i < size; i++)
                {
                    int idx = rand.Next(i, size-1);
                    Card temp = this.contents[idx];
                    this.contents[idx] = this.contents[i];
                    this.contents[i] = temp;
                }
            }
         }
         public Card Deal()
         {
             Card nextDraw = this.contents[0];
             this.contents.RemoveAt(0);
             return nextDraw;
         }
         public void Reset()
         {
            this.contents.Clear();
            string[] suitArray = {"Clubs", "Hearts", "Diamonds", "Spades"};
            foreach(string suit in suitArray)
            {
                for (int i = 0; i < 13; i++)
                {
                    Card newCard = new Card(suit, i);
                    contents.Add(newCard);
                }
            }
            this.Shuffle();
         }
    }
}