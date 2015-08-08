using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class CoursesServiceUnitTest
    {
        readonly CoursesService CoursesService;
        readonly CoursesDataService CoursesDataService;

        public CoursesServiceUnitTest()
        {
            CoursesDataService = new FakeData.FakeCoursesDataService();
            CoursesService = new FakeServices.FakeCoursesService(CoursesDataService);
        }

        [TestMethod]
        public void GetAllCourses()
        {
            var courses = (List<Course>)CoursesService.GetAll();
            Assert.IsTrue(courses.Count > 5);
        }

        [TestMethod]
        public void GetCourseById()
        {
            var courseId = 1;
            var course = CoursesService.GetById(courseId);
            Assert.AreEqual(courseId, course.Id);
        }

        [TestMethod]
        public void GetInstituteCoursesUnitTest()
        {
            var instituteId = 1;
            var courses = CoursesService.GetByInstitute(instituteId);
            Assert.IsNotNull(courses);
        }
    }
}