using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarotReaderServer.Models;

namespace TarotReaderServer.DAOs
{
    public interface ICardDAO
    {
         //Creates a list that holds all cards
        public List<Card> GetAllCards()

        /// <summary>
        /// Retrieves a Cards meaning property 
        /// depending on its place in a Spread List<Card></Card>
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="cardPlacement"></param>
        /// <param name="spreadId"></param>
        /// <returns>string</returns>
        string GetCardMeaning(int cardId, int spreadId, int cardPlacement);
    }
}
