using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Question : EntityBase
    {
        public string Text { get; set; }
        public Section Section { get; set; }
        public int Order { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
