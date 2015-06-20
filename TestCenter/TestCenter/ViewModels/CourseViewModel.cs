using TestCenter.Models;
using TestCenter.Services;

namespace TestCenter.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        private ICourseService Service;
        public new string Title
        {
            get
            {
                return "Course Details";
            }
            set{ }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        //public CourseViewModel() { }
        public CourseViewModel(Course course, ICourseService service)
        {
            //Service
            Service = service;
            //Entity
            Name = course.Name;
            Description = course.Description;
        }
    }
}
