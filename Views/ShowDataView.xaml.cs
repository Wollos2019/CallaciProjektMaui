using CallaciProjektMaui.Models;

namespace CallaciProjektMaui.Views;

public partial class ShowDataView : ContentPage
{
	public ShowDataView()
	{
		InitializeComponent();
        ShowData();
	}

    public async void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Question> questions = await App.QuestionRepo.GetAllQuestion();
        questionList.ItemsSource = questions;
    }

    public void ShowData()
    {
        statusMessage.Text = "";
        List<Question> questions = App.QuestionRepo.GetQuestions();
        questionList.ItemsSource = questions;
    }
}