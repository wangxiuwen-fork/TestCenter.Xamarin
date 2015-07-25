using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class InstituteServiceUnitTest
    {
        readonly InstituteService InstituteService;

        public InstituteServiceUnitTest()
        {
            InstituteService = new FakeServices.FakeInstituteService();
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
            var id = 1;
            var publisher = InstituteService.GetById(id);
            Assert.IsNotNull(publisher);
        }
    }
}
