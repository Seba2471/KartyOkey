using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class CardUtils
    {
        public static void ClearCardsButton(List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                ClearCardValue(button);
            }
        }

        public static void ClearCardValue(Button button)
        {
            button.Text = "";
            button.BackColor = Color.White;
        }

        public static void SetCardValue(Button button, string text, CardColors color)
        {
            button.Text = text;
            button.BackColor = Color.FromName(color.ToString());
        }

        public static void MoveCardValue(Button fromButton, Button toButton)
        {
            toButton.Text = fromButton.Text;
            toButton.BackColor = fromButton.BackColor;
        }

        public static Card GenerateRandomCard()
        {
            Random random = new Random();
            CardColors RandomColor = (CardColors)random.Next(1, 4);

            int RandomValue = random.Next(1, 9);
            Card card = new Card(RandomColor, RandomValue);

            return card;
        }

        public static void AddCardOnTheTable(Card card, ref List<Card> generatedCards, ref List<Button> tableButtons, Label cardLeft)
        {
            var slot = CardUtils.GetFreeSlotInTable(tableButtons);
            if (slot != null)
            {
                CardUtils.SetCardValue(slot, card.Value.ToString(), card.Color);
                generatedCards.Add(card);
                int value = Utils.GetIntValueFromLabelText(cardLeft);
                Utils.SetIntValueToLabelText(value - 1, cardLeft);
            }
        }

        public static void DeleteCards(ref List<SelectedCard> selectedCards)
        {
            foreach (SelectedCard card in selectedCards)
            {
                CardUtils.ClearCardValue(card.ToPosition);
                CardUtils.ClearCardValue(card.FromPosition);
            }
            selectedCards.Clear();
        }

        public static bool CardExists(Card card, ref List<Card> generatedCards)
        {
            bool exists = generatedCards.Any(c => c.Color == card.Color && c.Value == card.Value);

            return exists;
        }

        public static Button GetSlotInSelectedCard(List<Button> choosedButtons)
        {
            foreach (Button button in choosedButtons)
            {
                if (button.Text == "")
                {
                    return button;
                }
            }
            return null;
        }

        public static Button GetFreeSlotInTable(List<Button> tableButtons)
        {
            foreach (Button button in tableButtons)
            {
                if (button.Text == "")
                {
                    return button;
                }
            }

            return null;
        }
    }
}
