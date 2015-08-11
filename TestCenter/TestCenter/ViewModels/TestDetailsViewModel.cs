using System.Collections.Generic;
using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class TestDetailsViewModel : ViewModelBase
    {
        public new string Title { get { return Name; } }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public List<Instruction> Instructions { get; set; }
        public ICommand StartTestCommand { get; set; }

        readonly TestsService TestsService;
        readonly Navigator AppNavigator;

        public TestDetailsViewModel(Navigator navigator, TestsService testsServcice)
        {
            TestsService = testsServcice;
            AppNavigator = navigator;
            StartTestCommand = new Command(StartTest);
        }

        void StartTest()
        {
            AppNavigator.PushAsync<TestViewModel>(viewModel =>
            {
                viewModel.Id = Id;
                viewModel.Title = Name;
            });
        }
    }
}
