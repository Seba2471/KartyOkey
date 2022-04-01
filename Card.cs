using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class Card
    {
        public CardColors Color { get; set; }
        public int Value { get; set; }

        public Card(CardColors color, int value)
        {
            if (value > 0 && value < 9)
            {
                Color = color;
                Value = value;
            }
        }
    }
}
