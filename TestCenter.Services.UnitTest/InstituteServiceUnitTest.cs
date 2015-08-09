using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TestCenter.Data;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class InstituteServiceUnitTest
    {
        readonly InstituteService InstituteService;
        readonly InstituteDataService InstituteDataService;

        public InstituteServiceUnitTest()
        {
            InstituteDataService = new FakeData.FakeInstituteDataService();
            InstituteService = new FakeServices.FakeInstituteService(InstituteDataService);
        }

        [TestMethod]
        public void GetAllPublisherUnitTest()
        {
            var publishers = InstituteService.GetAllPublishers();
            Assert.IsTrue(publishers.Count() > 0);
        }

        [TestMethod]
        public void GetPublisherById()
        {
            Assert.IsNotNull(InstituteService.GetById(1));
        }
    }
}