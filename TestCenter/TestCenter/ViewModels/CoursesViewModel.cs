using System;
using System.Collections.Generic;
using TestCenter.Services;
using System.Linq;
using System.Windows.Input;
using TestCenter.Model;

namespace TestCenter.ViewModels
{
    public class CoursesViewModel : ViewModelBase
    {
        private readonly CoursesService Service;
        private readonly Func<Course, CourseViewModel> _courseViewModelFactory;
        public new string Title
        {
            get
            {
                return "Courses";
            }
            set { }
        }

        public IEnumerable<CourseViewModel> Courses { get; set; }
        public ICommand ShowCourseDetailsCommand { get; set; }
        public CoursesViewModel(CoursesService service, Func<Course, CourseViewModel> courseViewModelFactory)
        {
            Service = service;
            _courseViewModelFactory = courseViewModelFactory;

            Courses = Service.GetAllCourses().Select(c => _courseViewModelFactory(c));
        }
    }
}
