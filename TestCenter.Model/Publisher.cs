using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Publisher : EntityBase
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
