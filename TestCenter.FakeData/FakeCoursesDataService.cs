using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakeCoursesDataService : CoursesDataService
    {
        readonly List<Course> Courses;
        public FakeCoursesDataService()
        {
            Courses = new List<Course>
            {
                new Course { Id = 1, Name = "RTA", Detail="Driver Training" },
                new Course { Id = 2, Name = "Microsoft", Detail="Azure" },
                new Course { Id = 3, Name = "Xamarin", Detail="Xamarin.Forms" },
                new Course { Id = 4, Name = "Android", Detail="Xamarin.Android" },
                new Course { Id = 5, Name = "iOS", Detail="Xamarin.iOS" }
            };
        }

        public IEnumerable<Course> GetAll()
        {
            return Courses;
        }

        public Course GetById(int id)
        {
            return Courses.First(c => c.Id == id);
        }
    }
}
