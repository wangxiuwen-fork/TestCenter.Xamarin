using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;

namespace TestCenter.ViewModels
{
    public class TestDetailsViewModel : ViewModelBase
    {
        public new string Title { get { return Name; } }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public List<Instruction> Instructions { get; set; }
        //public List<Question> Questions { get; set; }
    }
}
