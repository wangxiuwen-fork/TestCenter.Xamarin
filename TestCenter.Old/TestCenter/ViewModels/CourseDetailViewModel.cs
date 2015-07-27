using System.Collections;
using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.ViewModels
{
    public class CourseDetailsViewModel : ViewModelBase
    {
        public new string Title
        {
            get
            {
                return Name;
            }
        }

        public int Id { get; set; }
        public int InstituteId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public IEnumerable<TestViewModel> Tests { get; set; }
    }
}
