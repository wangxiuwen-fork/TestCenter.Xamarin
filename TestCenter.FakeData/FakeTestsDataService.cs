using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakeTestsDataService : TestsDataService
    {
        readonly IEnumerable<Test> Tests;

        public FakeTestsDataService()
        {
            Tests = new List<Test>
            {
                new Test { Id = 1, CourseId = 1, Name = "Car", Detail = GetDetail(1), Instructions = GetTestInstructions(1), PreTestQuestions = GetTestQuestions(1), Questions = GetTestQuestions(1) },
                new Test { Id = 2, CourseId = 1, Name = "Motorcycle", Detail = GetDetail(2), Instructions = GetTestInstructions(2), Questions = GetTestQuestions(2) },
                new Test { Id = 3, CourseId = 1, Name = "Special Mobility Vehicle", Detail = GetDetail(3), Instructions = GetTestInstructions(3), Questions = GetTestQuestions(3) },
                new Test { Id = 4, CourseId = 1, Name = "Rigid Vehicle", Detail = GetDetail(4), Instructions = GetTestInstructions(4), Questions = GetTestQuestions(4) },
                new Test { Id = 5, CourseId = 1, Name = "Combination Vehicle", Detail = GetDetail(5), Instructions = GetTestInstructions(5), Questions = GetTestQuestions(5) },
                new Test { Id = 6, CourseId = 2, Name = GetName(6), Detail = GetDetail(6), Instructions = GetTestInstructions(6), Questions = GetTestQuestions(6) },
                new Test { Id = 7, CourseId = 3, Name = GetName(7), Detail = GetDetail(7), Instructions = GetTestInstructions(7), Questions = GetTestQuestions(7) },
            };
        }

        string GetName(int testId)
        {
            return string.Format("Test {0} Name", testId);
        }

        string GetDetail(int testId)
        {
            return string.Format("Test {0} Detail", testId);
        }

        List<Instruction> GetTestInstructions(int testId)
        {
            return new List<Instruction>
            {
                new Instruction { Id = 1, Text = "You will be asked 45 questions.\nYou are allowed 3 questions wrong in the first section, 'General Knowledge' and only one question wrong in either 'Road Safety' or 'Road Signs' section.", Order = 1 },
                new Instruction { Id = 2, Text = "You will be asked 45 questions. You are allowed 3 questions wrong in the first section, 'General Knowledge' and only one question wrong in either 'Road Safety' or 'Road Signs' section." + testId.ToString(), Order = 2 },
                new Instruction { Id = 3, Text = "Instruction3@Test " + testId.ToString(), Order = 3 },
                new Instruction { Id = 4, Text = "Instruction4@Test " + testId.ToString(), Order = 4 },
                new Instruction { Id = 5, Text = "Instruction5@Test " + testId.ToString(), Order = 5 },
            };
        }

        List<Question> GetTestQuestions(int testId)
        {
            return new List<Question>
            {
                new Question { Id = 1, Text = "Question1@Test " + testId.ToString(), Order = 1, Answers = GetAnswers(testId, 1) },
                new Question { Id = 2, Text = "Question2@Test " + testId.ToString(), Order = 2, Answers = GetAnswers(testId, 2) },
                new Question { Id = 3, Text = "Question3@Test " + testId.ToString(), Order = 3, Answers = GetAnswers(testId, 3) },
                new Question { Id = 4, Text = "Question4@Test " + testId.ToString(), Order = 4, Answers = GetAnswers(testId, 4) },
                new Question { Id = 5, Text = "Question5@Test " + testId.ToString(), Order = 5, Answers = GetAnswers(testId, 5) },
            };
        }

        List<Answer> GetAnswers(int testId, int questionId)
        {
            return new List<Answer>
            {
                new Answer { Id = 1, QuestionId = questionId, IsCorrect = false, Value = string.Format("Answer1@Test{0}|Question{1}", testId, questionId) },
                new Answer { Id = 2, QuestionId = questionId, IsCorrect = false, Value = string.Format("Answer2@Test{0}|Question{1}", testId, questionId) },
                new Answer { Id = 3, QuestionId = questionId, IsCorrect = false, Value = string.Format("Answer3@Test{0}|Question{1}", testId, questionId) },
                new Answer { Id = 4, QuestionId = questionId, IsCorrect = false, Value = string.Format("Answer4@Test{0}|Question{1}", testId, questionId) },
                new Answer { Id = 5, QuestionId = questionId, IsCorrect = true,  Value = string.Format("Answer5@Test{0}|Question{1}", testId, questionId) },
            };
        }

        public IEnumerable<Test> GetAll()
        {
            return Tests;
        }

        public Test GetById(int id)
        {
            return Tests.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Test> GetByCourse(int id)
        {
            return Tests.Where(t => t.CourseId == id).ToList();
        }
    }
}