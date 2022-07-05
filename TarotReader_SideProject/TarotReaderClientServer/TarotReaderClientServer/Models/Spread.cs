using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TarotReaderServer.Models
{
    public class Spread
    {
        public int Id { get; set; }

        public int Deck_id { get; set; }

        public string Name { get; set; }

    }
}
