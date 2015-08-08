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
                new Course { Id = 1, InstituteId = 1, Name = "RTA", Detail="NSW RTA, Driving Knowledge Test for Car." },
                new Course { Id = 2, InstituteId = 1, Name = "Microsoft", Detail="Azure" },
                new Course { Id = 3, InstituteId = 2, Name = "Xamarin", Detail="Xamarin.Forms" },
                new Course { Id = 4, InstituteId = 3, Name = "Android", Detail="Xamarin.Android" },
                new Course { Id = 5, InstituteId = 3, Name = "iOS", Detail="Xamarin.iOS" },
                new Course { Id = 6, InstituteId = 2, Name = "Samsung", Detail="Samsung Mobile" },
                new Course { Id = 7, InstituteId = 1, Name = "Apple", Detail="Apple" }
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

        public IEnumerable<Course> GetByInstitute(int instituteId)
        {
            return Courses.Where(c => c.InstituteId == instituteId);
        }
    }
}