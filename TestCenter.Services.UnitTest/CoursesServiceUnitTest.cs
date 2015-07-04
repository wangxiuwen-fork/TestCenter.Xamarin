using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;
using TestCenter.Data;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class CoursesServiceUnitTest
    {
        private readonly CoursesService CoursesService;
        private readonly CoursesDataService CoursesDataService;

        public CoursesServiceUnitTest()
        {
            CoursesDataService = new FakeData.FakeCoursesDataService();
            CoursesService = new FakeServices.FakeCoursesService(CoursesDataService);
        }

        [TestMethod]
        public void GetAllCourses()
        {
            var courses = (List<Course>)CoursesService.GetAll();
            Assert.AreEqual(courses.Count, 5);
        }

        [TestMethod]
        public void GetCourseById()
        {
            var course = CoursesService.GetById(1);
        }
    }
}
