using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface PublisherService
    {
        IEnumerable<Publisher> GetAllPublishers();
        Publisher GetById(int publisherId);
    }
}
