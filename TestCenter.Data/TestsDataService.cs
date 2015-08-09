using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Data
{
    public interface TestsDataService : RepositoryBase<Test>
    {
        IEnumerable<Test> GetByCourse(int id);
    }
}