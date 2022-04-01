using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class SelectedCard : Card
    {
        public Button FromPosition { get; set; }
        public Button ToPosition { get; set; }


        public SelectedCard(CardColors color, int value, Button fromPosition, Button toPosition) : base(color, value)
        {
            Color = color;
            Value = value;
            FromPosition = fromPosition;
            ToPosition = toPosition;
        }
    }
}
