using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakeTestsDataService : TestsDataService
    {
        readonly IEnumerable<Test> Tests;

        public FakeTestsDataService()
        {
            Tests = new List<Test>
            {
                new Test { Id = 1, CourseId = 1, Name = "Test 1", Detail = "Test 1" },
                new Test { Id = 2, CourseId = 1, Name = "Test 2", Detail = "Test 2" },
                new Test { Id = 3, CourseId = 2, Name = "Test 3", Detail = "Test 3" }
            };
        }

        public IEnumerable<Test> GetAll()
        {
            return Tests;
        }

        public Test GetById(int id)
        {
            return Tests.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Test> GetByCourseId(int id)
        {
            return Tests.Where(t => t.CourseId == id);
        }
    }
}