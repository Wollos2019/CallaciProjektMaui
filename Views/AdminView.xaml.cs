using CallaciProjektMaui.Models;
using System.Text.Json;

namespace CallaciProjektMaui.Views;

public partial class AdminView : ContentPage
{
    List<Answer> answersList = new List<Answer>();
    Answer[] answers = new Answer[3];
    Answer answer1 = new Answer();
    Answer answer2 = new Answer();
    Answer answer3 = new Answer();
    int selected = 0;

    public AdminView()
	{
		InitializeComponent();
	}

    private async void OnCreateBtnClicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        answersList = answers.ToList<Answer>();
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonAnswers = JsonSerializer.Serialize(answersList, options);
        await App.QuestionRepo.AddNewQuestion(
            mark.Text, questionText.Text, solution.Text, image.Text, jsonAnswers);
        statusMessage.Text = App.QuestionRepo.StatusMessage;
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex == 0)
        {
            selected = 0;
        }
        else if (selectedIndex == 1)
        {
            selected = 1;
        }
        else if (selectedIndex == 2)
        {
            selected = 2;
        }
    }

    private void OnSetBtnClicked(object sender, EventArgs e)
    {

        if (selected == 0)
        {
            answer1.Id = 0;
            answer1.Text = response.Text;
            answers[0] = answer1;
        }
        else if (selected == 1)
        {
            answer2.Id = 1;
            answer2.Text = response.Text;
            answers[1] = answer2;
        }
        else if (selected == 2)
        {
            answer3.Id = 2;
            answer3.Text = response.Text;
            answers[2] = answer3;
        }
    }
}