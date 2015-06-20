using System.Collections.Generic;
using TestCenter.Models;
using System.Linq;

namespace TestCenter.Services
{
    public class CourseService : ICourseService
    {
        private IEnumerable<Course> courses; 

        public CourseService()
        {
            courses = new List<Course>
            {
                new Course { Id = 1, Name = "RTA", Description="Driver Training" },
                new Course { Id = 2, Name = "Microsoft", Description="Azure" },
                new Course { Id = 3, Name = "Xamarin", Description="Xamarin.Forms" }
            };
        }

        public IEnumerable<Course> GetAllCourses()
        {
            //return new List<Course>
            //{
            //    new Course { Id = 1, Name = "RTA", Description="Driver Training" },
            //    new Course { Id = 2, Name = "Microsoft", Description="Azure" },
            //    new Course { Id = 3, Name = "Xamarin", Description="Xamarin.Forms" }
            //};
            return courses;
        }

        public Course GetById(int courseId)
        {
            return courses.Where(c => c.Id == courseId).FirstOrDefault();
        }
    }
}
