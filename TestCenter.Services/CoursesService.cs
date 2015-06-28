using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface CoursesService
    {
        IEnumerable<Course> GetAllCourses();
        Course GetById(int courseId);
    }
}
