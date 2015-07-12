using System;
using System.Collections.Generic;
using TestCenter.Services;
using System.Linq;
using System.Windows.Input;
using TestCenter.Model;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class CoursesViewModel : ViewModelBase
    {
        private readonly CoursesService Service;
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

        public CoursesViewModel(CoursesService service, Func<Course, CourseViewModel> courseViewModelFactory)
        {
            Service = service;
            CourseViewModelFactory = courseViewModelFactory;
            Courses = Service.GetAll().Select(c => CourseViewModelFactory(c));
        }
    }
}
