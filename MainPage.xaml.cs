namespace CallaciProjektMaui;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void MoveBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("QuizView");
    }
}

