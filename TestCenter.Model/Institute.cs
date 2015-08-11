using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Institute : EntityBase
    {
        public string Name { get; set; }
        public string Detail { get; set; }
        public string LogoImageSource { get; set; }
        public string WelcomeMessage { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}