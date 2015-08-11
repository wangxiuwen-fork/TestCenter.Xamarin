using System.Collections.Generic;

namespace TestCenter.Model
{
    public class Test : EntityBase
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public List<Instruction> Instructions { get; set; }
        public List<Question> PreTestQuestions { get; set; }
        public List<Question> Questions { get; set; }
    }
}