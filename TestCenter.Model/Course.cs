using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public IEnumerable<Test> Tests {get; set;}
    }
}
