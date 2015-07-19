using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface TestsService
    {
        IEnumerable<Test> GetAll();
        Test GetById(int courseId);
    }
}
