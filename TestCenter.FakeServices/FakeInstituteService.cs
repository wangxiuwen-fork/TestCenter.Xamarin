using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeInstituteService : InstituteService
    {
        readonly InstituteDataService DataService;

        public FakeInstituteService(InstituteDataService dataService)
        {
            DataService = dataService;
        }

        public IEnumerable<Institute> GetAllPublishers()
        {
            return DataService.GetAll();
        }

        public Institute GetById(int id)
        {
            return DataService.GetById(id);
        }
    }
}