using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestCenter.Services.UnitTest
{
    [TestClass]
    public class PublisherServiceUnitTest
    {
        readonly PublisherService PublisherService;

        public PublisherServiceUnitTest()
        {
            PublisherService = new FakeServices.FakePublisherService();
        }

        [TestMethod]
        public void GetAllPublisherUnitTest()
        {
            var publishers = PublisherService.GetAllPublishers();
            Assert.IsTrue(publishers.Count() > 0);
        }

        [TestMethod]
        public void GetPublisherById()
        {
            var id = 1;
            var publisher = PublisherService.GetById(id);
            Assert.IsNotNull(publisher);
        }
    }
}
