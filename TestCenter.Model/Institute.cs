using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Institute : EntityBase
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImageSource { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}