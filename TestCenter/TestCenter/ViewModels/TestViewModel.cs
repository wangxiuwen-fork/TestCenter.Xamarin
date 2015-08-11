using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; }
    }
}
