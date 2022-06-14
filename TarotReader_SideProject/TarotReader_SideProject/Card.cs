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

        public string Arcana { get; }
        public int CardNumber { get; }
        public string Name { get; }

        public bool Reversed { get; set; } = false;
    }
}
