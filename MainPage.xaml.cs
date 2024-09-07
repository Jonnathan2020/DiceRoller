namespace DiceRoller;

public partial class MainPage : ContentPage
{
    var picker = (Picker)sender;
    int selectedIndex = picker.SelectedIndex;

    public MainPage()
    {
        InitializeComponent();
    }

    private void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            // Obtém o item selecionado
            string selectedItem = (string)picker.ItemsSource[selectedIndex];
            // Atualiza o texto do Label
            selectedItemLabel.Text = $"Você selecionou: {selectedItem}";
        }
        else
        {
            selectedItemLabel.Text = "Selecione um item";
        }
       
    }

    private void Sortear_Clicked(object sender, EventArgs e)
    {
        public virtual int Next(int minValue, int maxValue);
    }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

    //Evidenciar de acordo com cada quantidade de lados selecionado de 4, 6, 8, 10, 20, 100

}

