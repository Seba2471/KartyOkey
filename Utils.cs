using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class Utils
    {
        public static int GetIntValueFromLabelText(Label label)
        {
            int value;
            int.TryParse(label.Text, out value);
            return value;
        }

        public static void SetIntValueToLabelText(int value, Label label)
        {
            label.Text = value.ToString();
        }

        public static int GetIntValueFromButtonText(Button button)
        {
            int value;
            int.TryParse(button.Text, out value);
            return value;
        }

        public static CardColors GetCardColorFromColor(Button button)
        {
            CardColors color;
            CardColors.TryParse(button.BackColor.Name, out color);
            return color;
        }
    }
}
