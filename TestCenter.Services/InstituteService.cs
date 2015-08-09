using System.Collections.Generic;
using TestCenter.Model;

namespace TestCenter.Services
{
    public interface InstituteService
    {
        IEnumerable<Institute> GetAllPublishers();

        Institute GetById(int publisherId);
    }
}