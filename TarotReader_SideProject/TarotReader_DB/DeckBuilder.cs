using System;
using System.Collections.Generic;
using System.Text;

namespace TarotReader_SideProject
{
    public class Deck
    {
        public Deck() { }

        List<Card> deck = new List<Card>();
        public bool BuildDeck(Card cardToAdd)
        {
            foreach (Card storedCard in deck)
            {
                if (storedCard.Name.Contains(cardToAdd.Name))
                {

                }
                else
                {
                    deck.Add(cardToAdd);
                }
            }
            return true;
        }
        public List<Card> GetDeck()
        {
            return deck;
        }

        

    }
}
