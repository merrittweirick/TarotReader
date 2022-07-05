using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarotReaderServer.Models;

namespace TarotReaderServer.DAOs
{
    public interface ISpreadDAO
    {
        /// <summary>
        /// Builds a List of Three cards from shuffled deck
        /// </summary>
        /// <returns>List<Card>[3]</returns>
        List<Card> ThreeCardDeck();
    }
}
