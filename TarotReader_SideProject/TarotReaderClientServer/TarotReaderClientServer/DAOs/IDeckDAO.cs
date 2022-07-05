using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarotReaderServer.Models;

namespace TarotReaderServer.DAOs
{
    public interface IDeckDAO
    {
        /// <summary>
        /// Assembles a list of All Objects of the Card class
        /// </summary>
        /// <returns>List of Cards Objects</returns>
        List<Card> BuildDeck();

        /// <summary>
        /// Shuffles/randomizes list of all cards and their reversed property
        /// and resets faceUp property of card to false
        /// </summary>
        /// <returns>List of randomized Card Objects</returns>
        List<Card> ShuffleDeck();
    }
}
