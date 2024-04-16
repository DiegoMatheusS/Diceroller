namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int valor = 0;

        public MainPage()
        {
            InitializeComponent();
            DiceTypePicker.SelectedIndex = 0;
        }

        private void RollBtn_Clicked(object sender, EventArgs e)
        {

            //Pegar o valor que foi selecionado pelo usuario
            valor = Convert.ToInt32(DiceTypePicker.SelectedItem);
            //jogar esse valor em uma variavel
            //Sortear um numero de um dado utilizando o Random
            //Colocar o valor sorteado em uma variavel


            int valorSorteado = 0;
            Dice dice = new Dice(valor);

            valorSorteado = dice.Rolar();
            //Exibir o vlaor para o usuario na resultLabel
            resultLabel.Text = valorSorteado.ToString();

        }
    }

}
