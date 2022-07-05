using System;
using System.Collections.Generic;
using System.Text;

namespace TarotReader_SideProject
{
    public abstract class Card
    {
        public Card (string arcana, int cardNumber, string name )
        {
            this.Arcana = arcana.ToLower();
            this.CardNumber = cardNumber;
            this.Name = name.ToUpper();

        }
        public int CardID { get; set; }
        public string Arcana { get; set; }
        public int CardNumber { get; set; }
        public string Name { get; set; }

        public bool Reversed { get; set; } = false;

        public string SituationMeaning { get; set; }

        public string ObstacleMeaning { get; set; }

        public string AdviceMeaning { get; set; }

    }
}
