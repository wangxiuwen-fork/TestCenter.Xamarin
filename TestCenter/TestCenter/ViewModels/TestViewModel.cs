using System.Collections.Generic;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public List<Question> PreTestQuestions { get; set; }
        public List<Question> Questions { get; set; }

        readonly TestsService TestsService;

        public TestViewModel(TestsService testsService)
        {
            TestsService = testsService;
        }
    }
}
