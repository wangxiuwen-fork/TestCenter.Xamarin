using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeCoursesService : CoursesService
    {
        //private readonly TestsService TestsService;
        private readonly CoursesDataService CoursesDataService;

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
