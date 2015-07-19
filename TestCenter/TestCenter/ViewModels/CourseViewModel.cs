using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        readonly CoursesService Service;
        readonly Navigator AppNavigator;

        public new string Title
        {
            get
            {
                return "Course Details";
            }
            set{ }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public ICommand ShowCourseDetailCommand { get; set; }

        public CourseViewModel(Course course, CoursesService service, Navigator navigator)
        {
            Service = service;
            AppNavigator = navigator;

            InitializeViewModelFromModel(course);

            ShowCourseDetailCommand = new Command(ShowCourseDetails);
        }

        void InitializeViewModelFromModel(Course course)
        {
            Id = course.Id;
            Name = course.Name;
            Detail = course.Detail;
        }

        void ShowCourseDetails()
        {
            var course = Service.GetById(Id);

            AppNavigator.PushAsync<CourseDetailsViewModel>(viewModel =>
            {
                viewModel.Id = Id;
                viewModel.Name = Name;
                viewModel.Detail = Detail;
            });
        }
    }
}
