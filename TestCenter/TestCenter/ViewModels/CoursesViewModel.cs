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
        readonly CoursesService Service;
        readonly Func<Course, CourseViewModel> CourseViewModelFactory;

        public int InstituteId { get; set; }

        public IEnumerable<CourseViewModel> Courses { get; set; }

        public CoursesViewModel(CoursesService service, Func<Course, CourseViewModel> courseViewModelFactory)
        {
            Title = AppResource.Course;
            Service = service;
            CourseViewModelFactory = courseViewModelFactory;
            Courses = Service.GetByInstitute(InstituteId).Select(c => CourseViewModelFactory(c));
        }
    }
}
