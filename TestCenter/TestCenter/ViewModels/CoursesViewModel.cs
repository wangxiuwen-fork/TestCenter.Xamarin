using System;
using System.Collections.Generic;
using TestCenter.Models;
using TestCenter.Services;
using System.Linq;
using System.Windows.Input;

namespace TestCenter.ViewModels
{
    public class CoursesViewModel : ViewModelBase
    {
        private readonly ICourseService Service;
        private readonly Func<Course, CourseViewModel> CourseViewModelFactory;
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
        public CoursesViewModel(ICourseService service, Func<Course, CourseViewModel> courseViewModelFactory)
        {
            Service = service;
            CourseViewModelFactory = courseViewModelFactory;

            Courses = Service.GetAllCourses().Select(c => CourseViewModelFactory(c));
        }
    }
}
