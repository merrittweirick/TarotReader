using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TarotReaderServer.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string Card_name { get; set; }

        public string Arcana { get; set; }

        public bool Reversed { get; set; } = false;

        public string Situation_meaning { get; set; }
        public string Situation_meaning_rev { get; set; }
        public string Obstacle_meaning { get; set; }
        public string Obstacle_meaning_rev { get; set; }
        public string Advice_meaning { get; set; }
        public string Advice_meaning_rev { get; set; }
    }
}
