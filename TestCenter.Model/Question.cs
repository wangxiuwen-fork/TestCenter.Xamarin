using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCenter.Model
{
    public class Question : EntityBase
    {
        public string Text { get; set; }
        public int Order { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
