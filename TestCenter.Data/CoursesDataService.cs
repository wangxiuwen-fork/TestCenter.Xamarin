using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Data
{
    public interface CoursesDataService : RepositoryBase<Course>
    {
        IEnumerable<Course> GetByInstitute(int instituteId);
    }
}
