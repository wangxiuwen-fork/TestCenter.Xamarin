using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeCoursesService : CoursesService
    {
        private readonly TestsService TestService;

        private IEnumerable<Course> Courses;

        public FakeCoursesService(TestsService testService)
        {
            TestService = testService;

            Courses = new List<Course>
            {
                new Course { Id = 1, Name = "RTA", Detail="Driver Training", Tests = TestService.GetTestsByCourse(1) },
                new Course { Id = 2, Name = "Microsoft", Detail="Azure", Tests = TestService.GetTestsByCourse(2) },
                new Course { Id = 3, Name = "Xamarin", Detail="Xamarin.Forms", Tests = TestService.GetTestsByCourse(3) },
                new Course { Id = 4, Name = "Android", Detail="Xamarin.Android", Tests = TestService.GetTestsByCourse(4) },
                new Course { Id = 5, Name = "iOS", Detail="Xamarin.iOS", Tests = TestService.GetTestsByCourse(5) }
            };
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return Courses;
        }

        public Course GetById(int courseId)
        {
            return Courses.Where(c => c.Id == courseId).FirstOrDefault();
        }
    }
}
