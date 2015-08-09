using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class TestServicesUnitTest
    {
        readonly TestsService TestsService;
        readonly TestsDataService TestsDataService;

        public TestServicesUnitTest()
        {
            TestsDataService = new FakeData.FakeTestsDataService();
            TestsService = new FakeServices.FakeTestsService(TestsDataService);
        }

        [TestMethod]
        public void GetAllTestByCourseId()
        {
            var tests = (List<Test>)TestsService.GetByCourse(1);
            Assert.IsTrue(tests.Count > 0);
        }

        [TestMethod]
        public void GetById()
        {
            var test = TestsService.GetById(1);
            Assert.IsNotNull(test);
        }

        [TestMethod]
        public void TestHasIntructions()
        {
            var test = TestsService.GetById(1);
            Assert.IsTrue(test.Instructions.Count > 0);
        }

        [TestMethod]
        public void TestHasQuestions()
        {
            var test = TestsService.GetById(1);
            Assert.IsTrue(test.Questions.Count > 0);
        }

        [TestMethod]
        public void TestQuestionHasAnswers()
        {
            var test = TestsService.GetById(1);
            Assert.IsTrue(test.Questions.FirstOrDefault().Answers.Count > 0);
        }
    }
}
