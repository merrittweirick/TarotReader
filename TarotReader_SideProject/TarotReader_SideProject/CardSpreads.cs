using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//Ask Matt about Linq

namespace TarotReader_SideProject
{
    public class CardSpreads
    {
        List<Card> deck = new List<Card>();
        public CardSpreads()
        {

        }
        public bool BuildDeck(Card cardToAdd)
        {
            foreach(Card storedCard in deck)
            {
                if(storedCard.Name.Contains(cardToAdd.Name))
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
        public List<Card> ShuffleDeck()
        {
            
            var rnd = new Random();

            deck = deck.OrderBy(card => rnd.Next()).ToList();
            foreach (Card card in deck)
            {
                if(rnd.Next(2)==0)
                {
                    card.Reversed = true;
                }
                else
                {
                    card.Reversed = false;
                }
            }
            return deck;
        }

        public List<string> ThreeCardSpread(List<Card> deck)
        {
            List<Card> threeCardDeck = deck.GetRange(0, 3); //Basically creates "substring" of deck list (should create list o first three indexes in Deck)
            List<string> threeSpreadReading = new List<string>(); 

            for (int i = 0; i < threeCardDeck.Count; i++)
            {
                if (i == 0)
                {
                    string situation = deck[0].SituationMeaning;
                    threeSpreadReading[0] = situation;
                }
                else if (i == 1)
                {
                    string obstacle = deck[1].ObstacleMeaning;
                    threeSpreadReading[1] = obstacle;
                }
                else
                {
                    string advice = deck[2].AdviceMeaning;
                    threeSpreadReading[2] = advice;
                }
            }
            
            
        }
    }
}
