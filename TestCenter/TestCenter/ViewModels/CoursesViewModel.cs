using System.Collections.Generic;
using TestCenter.Localization;

namespace TestCenter.ViewModels
{
    public class CoursesViewModel : ViewModelBase
    {
        public int InstituteId { get; set; }

        public IEnumerable<CourseViewModel> Courses { get; set; }

        public CoursesViewModel()
        {
            Title = AppResource.Courses;
        }
    }
}