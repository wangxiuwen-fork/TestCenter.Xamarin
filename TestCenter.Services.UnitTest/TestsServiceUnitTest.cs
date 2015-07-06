using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class TestsServiceUnitTest
    {
        private readonly TestsService Service;

        public TestsServiceUnitTest(TestsService service)
        {
            Service = new FakeServices.FakeTestsService();
        }
        
        [TestMethod]
        public void GetAllTests()
        {
            var tests = (List<Test>)Service.GetAllTests();
            Assert.Equals(tests.Count, 3);
        }
    }
}
