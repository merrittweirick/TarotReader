using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TarotReaderServer.Models
{
    public class CardSpread
    {
        
        
        public int Card_id { get; set; }
        public int Spread_id { get; set; }

        public bool Reversed { get; set; }
        public int Placement_number { get; set; }

        
    }
}
