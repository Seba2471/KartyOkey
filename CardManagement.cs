using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartyOkey
{
    internal class CardManagement
    {
        public static void AddNewCardOnTheTable(ref List<Card> generatedCards, Label cardLeft, List<Button> tableButtons,
             ref List<SelectedCard> selectedCards)
        {
            int value = Utils.GetIntValueFromLabelText(cardLeft);

            ReturnSelectedCards(ref selectedCards);

            if (value > 0)
            {
                Card card = CardUtils.GenerateRandomCard();

                if (generatedCards.Count == 0)
                {
                    CardUtils.AddCardOnTheTable(card, ref generatedCards, ref tableButtons, cardLeft);
                }
                else
                {
                    while (CardUtils.CardExists(card, ref generatedCards))
                    {
                        card = CardUtils.GenerateRandomCard();
                    }
                    CardUtils.AddCardOnTheTable(card, ref generatedCards, ref tableButtons, cardLeft);
                }
            }
        }

        public static void ReturnSelectedCards(ref List<SelectedCard> selectedCards)
        {
            if (selectedCards.Count > 0)
            {
                foreach (SelectedCard card in selectedCards)
                {
                    CardUtils.MoveCardValue(card.ToPosition, card.FromPosition);
                    CardUtils.ClearCardValue(card.ToPosition);
                }
                selectedCards.Clear();
            }
        }

        public static void ReturnSelectedCard(Button button, ref List<SelectedCard> selectedCards)
        {
            SelectedCard card = selectedCards.FirstOrDefault(c => c.ToPosition == button);
            if (card != null)
            {
                selectedCards.RemoveAll(c => c == card);
                CardUtils.MoveCardValue(card.ToPosition, card.FromPosition);
                CardUtils.ClearCardValue(button);
            }
        }

        public static void SelectCard(Button button, ref List<SelectedCard> selectedCards, List<Button> choosedButtons, Label label)
        {
            CardColors color = Utils.GetCardColorFromColor(button);
            if (color != 0)
            {
                var slot = CardUtils.GetSlotInSelectedCard(choosedButtons);
                SelectedCard selectedCard = new SelectedCard(color, Utils.GetIntValueFromButtonText(button), button, slot);
                selectedCards.Add(selectedCard);
                if (slot != null)
                {
                    CardUtils.SetCardValue(slot, selectedCard.Value.ToString(), selectedCard.Color);
                }
                CardUtils.ClearCardValue(button);
                if (slot.Name == "choose3")
                {
                    int value = CheckCombinations.CheckCombination(selectedCards);
                    if (value > 0)
                    {
                        int points = Utils.GetIntValueFromLabelText(label);
                        Utils.SetIntValueToLabelText(points + value, label);
                        CardUtils.DeleteCards(ref selectedCards);
                    }
                    else
                    {
                        ReturnSelectedCards(ref selectedCards);
                    }
                }
            }

        }
    }
}
