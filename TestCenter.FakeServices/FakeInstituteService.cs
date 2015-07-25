using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeInstituteService : InstituteService
    {
        readonly InstituteDataService PublisherDataService;

        public FakeInstituteService()
        {
            PublisherDataService = new FakeData.FakeInstituteDataService();
        }

        public IEnumerable<Institute> GetAllPublishers()
        {
            return PublisherDataService.GetAll();
        }

        public Institute GetById(int id)
        {
            return PublisherDataService.GetById(id);
        }
    }
}
