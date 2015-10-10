using System.Collections.Generic;
using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public List<Question> PreTestQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public int CurrentIndex { get; set; }
        public ICommand NextQuestion { get; set; }
        public ICommand ConfirmAnswer { get; set; }

        readonly TestsService TestsService;

        public TestViewModel(TestsService testsService)
        {
            TestsService = testsService;
            CurrentIndex = -1;
            NextQuestion = new Command(ShowNextQuestion);
            ConfirmAnswer = new Command(ConfirmSelectedAnswer);
        }

        void ShowNextQuestion()
        {
            CurrentIndex++;
            //if (CurrentIndex < Questions.Count)
            //{
            //    AppNavigator.PushAsync<TestViewModel>(viewModel =>
            //    {
            //        viewModel.Id = Id;
            //        //viewModel.Title = Name;
            //        //viewModel.PreTestQuestions = test.PreTestQuestions;
            //        //viewModel.Questions = test.Questions;
            //    });
            //}
        }

        void ConfirmSelectedAnswer()
        {

        }
    }
}
