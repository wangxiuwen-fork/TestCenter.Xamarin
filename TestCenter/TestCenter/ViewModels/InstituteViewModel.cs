using System;
using System.Linq;
using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class InstituteViewModel : ViewModelBase
    {
        readonly InstituteService Service;
        readonly CoursesService CoursesService;
        readonly Navigator AppNavigator;

        readonly Func<Course, CourseViewModel> CourseViewModelFactory;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public ICommand ShowCoursesCommand { get; set; }

        public InstituteViewModel(Institute institute, InstituteService service, CoursesService coursesService, Navigator navigator, Func<Course, CourseViewModel> courseViewModelFactory)
        {
            Service = service;
            CoursesService = coursesService;
            AppNavigator = navigator;
            CourseViewModelFactory = courseViewModelFactory;

            ShowCoursesCommand = new Command(ShowCourses);

            InitializeViewModelFromModel(institute);
        }

        void InitializeViewModelFromModel(Institute institute)
        {
            Id = institute.Id;
            Name = institute.Name;
            Detail = institute.Detail;
        }

        void ShowCourses()
        {
            AppNavigator.PushAsync<CoursesViewModel>(viewModel => {
                viewModel.InstituteId = Id;
                viewModel.Courses = CoursesService.GetByInstitute(Id).Select(c => CourseViewModelFactory(c));
            });
        }
    }
}
