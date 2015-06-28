using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface TestsService
    {
        IEnumerable<Test> GetTestsByCourse(int courseId);
    }
}
