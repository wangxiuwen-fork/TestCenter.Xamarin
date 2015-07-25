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
        
        public int Id { get; set; }
        public int InstituteId { get; set; }
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
            InstituteId = course.InstituteId;
            Name = course.Name;
            Detail = course.Detail;
        }

        void ShowCourseDetails()
        {
            var course = Service.GetById(Id);

            AppNavigator.PushAsync<CourseDetailsViewModel>(viewModel =>
            {
                viewModel.Id = Id;
                viewModel.InstituteId = InstituteId;
                viewModel.Name = Name;
                viewModel.Detail = Detail;
            });
        }
    }
}
