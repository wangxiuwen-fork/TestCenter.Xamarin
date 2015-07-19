using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeCoursesService : CoursesService
    {
        readonly CoursesDataService CoursesDataService;

        public FakeCoursesService(CoursesDataService coursesDataService)
        {
            CoursesDataService = coursesDataService;
        }

        public IEnumerable<Course> GetAll()
        {
            return CoursesDataService.GetAll();
        }

        public Course GetById(int courseId)
        {
            return CoursesDataService.GetById(courseId);
        }
    }
}
