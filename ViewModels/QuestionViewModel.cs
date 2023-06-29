using CallaciProjektMaui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CallaciProjektMaui.ViewModels
{
    public class QuestionViewModel
    {
        public ObservableCollection<Question> Questions { get; set; }
        public ICommand DeleteQuestionCommand { get; private set; }

        [ObservableProperty]
        bool isRefreshing;
        public QuestionViewModel()
        {
            DeleteQuestionCommand = new Command(async (question) =>
            {
               await App.QuestionRepo.removeQuestion((question as Question).Id);
            });
        }
    }
}
