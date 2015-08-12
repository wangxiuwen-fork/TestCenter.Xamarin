using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeTestsService : TestsService
    {
        readonly TestsDataService DataService;

        public FakeTestsService(TestsDataService dataService)
        {
            DataService = dataService;
        }

        public IEnumerable<Test> GetAll()
        {
            return DataService.GetAll();
        }

        public IEnumerable<Test> GetByCourse(int courseId)
        {
            return DataService.GetByCourse(courseId);
        }

        public Test GetById(int id)
        {
            return DataService.GetById(id);
        }
    }
}