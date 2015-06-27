using System.Collections.Generic;
using TestCenter.Model;
using System.Linq;

namespace TestCenter.Services
{
    public class FakeCoursesService : CoursesService
    {
        private IEnumerable<Course> _courses; 

        public FakeCoursesService()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, Name = "RTA", Detail="Driver Training" },
                new Course { Id = 2, Name = "Microsoft", Detail="Azure" },
                new Course { Id = 3, Name = "Xamarin", Detail="Xamarin.Forms" },
                new Course { Id = 4, Name = "Android", Detail="Xamarin.Android" },
                new Course { Id = 5, Name = "iOS", Detail="Xamarin.iOS" }
            };
        }

        public IEnumerable<Course> GetAllCourses()
        {   
            return _courses;
        }

        public Course GetById(int courseId)
        {
            return _courses.Where(c => c.Id == courseId).FirstOrDefault();
        }
    }
}
