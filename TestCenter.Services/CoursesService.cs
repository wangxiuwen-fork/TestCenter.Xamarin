using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface CoursesService
    {
        IEnumerable<Course> GetAll();
        IEnumerable<Course> GetByInstitute(int instituteId);
        Course GetById(int courseId);
    }
}
