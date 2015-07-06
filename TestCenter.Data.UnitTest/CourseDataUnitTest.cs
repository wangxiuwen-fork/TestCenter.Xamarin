using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Data.UnitTest
{
    [TestClass]
    public class CourseDataUnitTest
    {
        private readonly CoursesDataService CoursesDataService;

        public CourseDataUnitTest()
        {
            CoursesDataService = new FakeData.FakeCoursesDataService();
        }

        [TestMethod]
        public void GetAllCourses()
        {
            var courses = (List<Course>) CoursesDataService.GetAll();
            Assert.AreEqual(courses.Count, 5);
        }

        [TestMethod]
        public void GetCourseById()
        {
            var course = CoursesDataService.GetById(1);
            Assert.AreEqual(course.Id, 1);
        }
    }
}
