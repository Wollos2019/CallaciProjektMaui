using CallaciProjektMaui.Models;
using System.Text.Json;

namespace CallaciProjektMaui.Views;

public partial class QuizView : ContentPage
{
	public QuizView()
	{
		InitializeComponent();
        OnGetBtnClicked();
	}

    public async void OnGetBtnClicked()
    {
        statusMessage.Text = "";
        List<Question> questions = await App.QuestionRepo.GetAllQuestion();
        foreach (Question question in questions)
        {
            //imageBox.Source = question.Image;
            List<Answer> answers = JsonSerializer.Deserialize<List<Answer>>(question.Answers);
            AnswerBtn.Text = answers.ElementAt(0).Text;
            AnswerBtn2.Text = answers.ElementAt(1).Text;
            AnswerBtn3.Text = answers.ElementAt(2).Text;
            qtnLabel.Text = question.QuestionText;
            await Task.Delay(2000000);
        }
    }
}