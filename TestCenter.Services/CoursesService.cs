using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface CoursesService
    {
        IEnumerable<Course> GetAll();
        Course GetById(int courseId);
    }
}
