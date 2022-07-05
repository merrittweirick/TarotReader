using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TarotReaderServer.Models
{
    public class Deck
    {
        public int Deck_id { get; set; }
        public int Card_id { get; set; }
        public bool Dealt { get; set; }
    }
}
