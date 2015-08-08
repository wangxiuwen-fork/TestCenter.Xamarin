using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class TestServicesUnitTest
    {
        readonly TestsService FakeTestsService;

        public TestServicesUnitTest()
        {
            FakeTestsService = new FakeServices.FakeTestsService();
        }

        [TestMethod]
        public void GetAllTestByCourseId()
        {
            var tests = (List<Test>)FakeTestsService.GetByCourse(1);
            Assert.IsTrue(tests.Count > 0);
        }
    }
}