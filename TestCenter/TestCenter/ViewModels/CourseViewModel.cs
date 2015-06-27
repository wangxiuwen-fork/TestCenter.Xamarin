using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        private CoursesService Service;
        public new string Title
        {
            get
            {
                return "Course Details";
            }
            //set{ }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        //public CourseViewModel() { }
        public CourseViewModel(Course course, CoursesService service)
        {
            //Service
            Service = service;
            //Entity
            Name = course.Name;
            Description = course.Detail;
        }
    }
}
