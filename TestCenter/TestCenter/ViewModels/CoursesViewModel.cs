using System;
using System.Collections.Generic;
using TestCenter.Services;
using System.Linq;
using TestCenter.Model;
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
