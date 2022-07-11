using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TarotReaderServer.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Name { get; set; }
        public string Arcana { get; set; }
        public string As_situation { get; set; }
        public string As_situation_rev { get; set; }
        public string As_obstacle { get; set; }
        public string As_obstacle_rev { get; set; }
        public string As_advice { get; set; }
        public string As_advice_rev { get; set; }
    }
}
