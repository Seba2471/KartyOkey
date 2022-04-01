using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class CheckCombinations
    {

        public static int CheckCombination(List<SelectedCard> cards)
        {
            int value = cards.Select(c => c.Value).OrderBy(v => v).First();

            if (IsTheSame(cards))
            {
                return value * 10 + 10;
            }

            if (IsSeries(cards))
            {
                if (IsTheSameColor(cards))
                {
                    return 100;
                }
                else
                {
                    return value * 10;
                }
            }

            return 0;
        }
        private static bool IsTheSameColor(List<SelectedCard> cards)
        {
            CardColors color = cards[0].Color;

            foreach (var card in cards.Skip(1))
            {
                if (color != card.Color)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSeries(List<SelectedCard> cards)
        {
            var values = cards.Select(c => c.Value).OrderBy(v => v);

            for (int i = 0; i < values.Count(); i++)
            {
                if (i + 1 < values.Count())
                {
                    if (values.ElementAt(i) + 1 != values.ElementAt(i + 1))
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        private static bool IsTheSame(List<SelectedCard> cards)
        {
            var values = cards.Select(c => c.Value);

            int start = values.ElementAt(0);

            foreach (var value in values.Skip(1))
            {
                if (value != start)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
