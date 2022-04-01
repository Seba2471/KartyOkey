namespace KartyOkey
{
    public partial class Form1 : Form
    {
        List<Card> GeneratedCards = new List<Card>();
        List<SelectedCard> SelectedCards = new List<SelectedCard>();
        List<Button> choosedButtons = new List<Button>();
        private List<Button> tableButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            choosedButtons.Add(choose1);
            choosedButtons.Add(choose2);
            choosedButtons.Add(choose3);

            tableButtons.Add(table1);
            tableButtons.Add(table2);
            tableButtons.Add(table3);
            tableButtons.Add(table4);
            tableButtons.Add(table5);
        }

        private void NewCard_Click(object sender, EventArgs e)
        {
            CardManagement.AddNewCardOnTheTable(ref GeneratedCards, CardLeft, tableButtons, ref SelectedCards);
        }

        private void table5_Click(object sender, EventArgs e)
        {
            CardManagement.SelectCard(table5, ref SelectedCards, choosedButtons, EarnPoints);
        }

        private void table4_Click(object sender, EventArgs e)
        {
            CardManagement.SelectCard(table4, ref SelectedCards, choosedButtons, EarnPoints);
        }

        private void table3_Click(object sender, EventArgs e)
        {
            CardManagement.SelectCard(table3, ref SelectedCards, choosedButtons, EarnPoints);
        }

        private void table2_Click(object sender, EventArgs e)
        {
            CardManagement.SelectCard(table2, ref SelectedCards, choosedButtons, EarnPoints);
        }

        private void table1_Click(object sender, EventArgs e)
        {
            CardManagement.SelectCard(table1, ref SelectedCards, choosedButtons, EarnPoints);
        }

        private void table1delete_Click(object sender, EventArgs e)
        {
            CardUtils.ClearCardValue(table1);
        }

        private void table2delete_Click(object sender, EventArgs e)
        {
            CardUtils.ClearCardValue(table2);
        }

        private void table3delete_Click_1(object sender, EventArgs e)
        {
            CardUtils.ClearCardValue(table3);
        }

        private void table4delete_Click(object sender, EventArgs e)
        {
            CardUtils.ClearCardValue(table4);
        }

        private void table5delete_Click(object sender, EventArgs e)
        {
            CardUtils.ClearCardValue(table5);
        }

        private void choose1_Click(object sender, EventArgs e)
        {
            CardManagement.ReturnSelectedCard(choose1, ref SelectedCards);
        }

        private void choose2_Click(object sender, EventArgs e)
        {
            CardManagement.ReturnSelectedCard(choose2, ref SelectedCards);
        }

        private void choose3_Click(object sender, EventArgs e)
        {
            CardManagement.ReturnSelectedCard(choose3, ref SelectedCards);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            CardUtils.ClearCardsButton(tableButtons);
            CardUtils.ClearCardsButton(choosedButtons);
            GeneratedCards.Clear();
            Utils.SetIntValueToLabelText(0, EarnPoints);
            Utils.SetIntValueToLabelText(24, CardLeft);
        }
    }
}