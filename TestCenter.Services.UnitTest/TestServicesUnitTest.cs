using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCenter.Data;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class TestServicesUnitTest
    {
        readonly TestsDataService TestsDataService;

        public TestServicesUnitTest()
        {
            TestsDataService = new FakeData.FakeTestsDataService();
        }

        [TestMethod]
        public void GetAllTestByCourseId()
        {
        }
    }
}
