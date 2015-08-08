using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface TestsService
    {
        Test GetById(int testId);

        IEnumerable<Test> GetAll();

        IEnumerable<Test> GetByCourse(int courseId);
    }
}