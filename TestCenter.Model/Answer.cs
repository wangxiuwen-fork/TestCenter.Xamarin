namespace TestCenter.Model
{
    public class Answer:EntityBase
    {
        public int QuestionId { get; set; }
        public string Value { get; set; }
        public bool IsCorrect { get; set; }
    }
}