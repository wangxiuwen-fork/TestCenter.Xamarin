using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        private readonly CoursesService Service;
        private readonly Navigator Navigation;
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

        public ICommand ShowCourseDetail { get; set; }

        public CourseViewModel(Course course, CoursesService service, Navigator navigator)
        {
            //Service
            Service = service;
            Navigation = navigator;
            //Entity
            Id = course.Id;
            Name = course.Name;
            Detail = course.Detail;
            ShowCourseDetail = new Command(Details);
        }

        private void Details()
        {
            Course course = Service.GetById(Id);

            Navigation.PushAsync<CourseViewModel>(viewModel => {
                viewModel.Name = Name;
                viewModel.Detail = Detail;
            });
        }
    }
}
