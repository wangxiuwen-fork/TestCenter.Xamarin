using System.Collections.Generic;

namespace TestCenter.ViewModels
{
    public class TestsViewModel : ViewModelBase
    {
        public new string Title
        {
            get
            {
                return "Available Tests";
            }
        }

        public IEnumerable<TestViewModel> AvailableTests { get; set; }
    }
}
