using TestCenter.Model;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public TestViewModel(Test test)
        {
            Id = test.Id;
            Name = test.Name;
            Detail = test.Detail;
        }
    }
}
