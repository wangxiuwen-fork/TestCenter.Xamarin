using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakePublisherDataService : PublisherDataService
    {
        readonly IEnumerable<Publisher> Publishers;

        public FakePublisherDataService()
        {
            Publishers = new List<Publisher>
            {
                new Publisher { Id = 1, Name = "NSW RTA", Detail = "Test 11 Detail" },
                new Publisher { Id = 2, Name = "QLD RTA", Detail = "Test 12 Detail" },
                new Publisher { Id = 3, Name = "TAS RTA", Detail = "Test 13 Detail" }
            };
        } 

        public IEnumerable<Publisher> GetAll()
        {
            return Publishers;
        }

        public Publisher GetById(int id)
        {
            return Publishers.FirstOrDefault(p => p.Id == id);
        }
    }
}
