using System.Collections.Generic;
using TestCenter.Models;

namespace TestCenter.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        Course GetById(int courseId);
    }
}