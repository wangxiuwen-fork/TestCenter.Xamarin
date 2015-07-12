using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            var courseId = 1;
            var course = CoursesService.GetById(courseId);
            Assert.AreEqual(courseId, course.Id);
        }
    }
}
