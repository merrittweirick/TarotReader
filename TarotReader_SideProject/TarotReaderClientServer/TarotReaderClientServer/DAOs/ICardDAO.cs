using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarotReaderServer.Models;

namespace TarotReaderServer.DAOs
{
    public interface ICardDAO
    {
        List<Card> BuildFullDeck();

        Card GetCardById(int id);
        Card GetCardByName(string name);
        List<Card> BuildDeckByArcana(string arcana);
        
    }
}
