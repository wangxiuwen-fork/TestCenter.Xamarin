using System.Collections.Generic;
using System.Linq;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeTestsService : TestsService
    {
        readonly IEnumerable<Test> Tests;

        public FakeTestsService()
        {
            Tests = new List<Test>
            {
                new Test { Id = 1, CourseId = 1, Name = "Test 01 Name", Detail = "Test 11 Detail" },
                new Test { Id = 2, CourseId = 2, Name = "Test 02 Name", Detail = "Test 12 Detail" },
                new Test { Id = 3, CourseId = 2, Name = "Test 03 Name", Detail = "Test 13 Detail" }
            };
        }

        public IEnumerable<Test> GetAll()
        {
            return Tests;
        }

        public Test GetById(int courseId)
        {
            return Tests.FirstOrDefault(t => t.CourseId == courseId);
        }
    }
}
