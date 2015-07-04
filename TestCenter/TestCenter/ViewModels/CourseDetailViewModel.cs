using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCenter.ViewModels
{
    public class CourseDetailViewModel : ViewModelBase
    {
        public new string Title
        {
            get
            {
                return "Course Details";
            }
        }

        public string Name { get; set; }
        public string Detail { get; set; }
    }
}
