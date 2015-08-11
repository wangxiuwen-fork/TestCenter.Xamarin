using System.Collections.Generic;

namespace TestCenter.ViewModels
{
    public class TestsViewModel : ViewModelBase
    {
        public new string Title
        {
            get
            {
                return Localization.AppResource.AvailableTest;
            }
        }

        public IEnumerable<TestsListItemViewModel> AvailableTests { get; set; }
    }
}