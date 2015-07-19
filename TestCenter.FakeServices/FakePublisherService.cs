using System;
using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakePublisherService : PublisherService
    {
        readonly PublisherDataService PublisherDataService;

        public FakePublisherService()
        {
            PublisherDataService = new FakeData.FakePublisherDataService();
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            return PublisherDataService.GetAll();
        }

        public Publisher GetById(int id)
        {
            return PublisherDataService.GetById(id);
        }
    }
}
