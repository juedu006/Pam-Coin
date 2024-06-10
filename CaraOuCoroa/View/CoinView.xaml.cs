namespace CaraOuCoroa.View;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
	}

    private void JogarMoeda_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();

        int DescCoin = random.Next(1, 3);

        if (DescCoin == 1)
        {
            CoinImg.Source = "cara.png";

            string selectSides = EscolherLado.SelectedItem.ToString();

            if (selectSides == "Cara")
            {
                LabelResult.Text = "Você Ganhou!";
            }
            else
            {
                LabelResult.Text = "Você Perdeu! ;-;";
            }
        }
        else
        {
            CoinImg.Source = "coroa.png";

            string selectSides = EscolherLado.SelectedItem.ToString();

            if (selectSides == "Coroa")
            {
                LabelResult.Text = "Você Ganhou!";
            }
            else
            {
                LabelResult.Text = "Você Perdeu! ;-;";
            }
        }
    }
}