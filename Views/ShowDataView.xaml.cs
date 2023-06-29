using CallaciProjektMaui.Models;
using CallaciProjektMaui.ViewModels;
using System.Collections.ObjectModel;

namespace CallaciProjektMaui.Views;

public partial class ShowDataView : ContentPage
{
    public QuestionViewModel DefaultViewModel { get; } = new QuestionViewModel();
    
	public ShowDataView()
	{
		InitializeComponent();
        ShowData();
	}

    public async void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Question> questions = await App.QuestionRepo.GetAllQuestion();
        //questionList.ItemsSource = questions;
    }

    public void ShowData()
    {
        statusMessage.Text = "";
        List<Question> questions = App.QuestionRepo.GetQuestions();
        questionList.ItemsSource = questions;

        //foreach (Question question in questions)
        //{
        //    DefaultViewModel.Questions.Add(question);
        //}
    }
}