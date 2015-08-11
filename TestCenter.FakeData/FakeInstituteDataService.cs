using System.Collections.Generic;
using System.Linq;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakeInstituteDataService : InstituteDataService
    {
        readonly IEnumerable<Institute> Publishers;

        public FakeInstituteDataService()
        {
            Publishers = new List<Institute>
            {
                new Institute { Id = 1, Name = "Roads and Traffic Authority of NSW", Detail = "RTA NSW", WelcomeMessage = "Welcome to RTA's Online Demonstration Driver Knowledge Test", LogoImageSource = "http://myrta.com/ebus/images/odkt/dkt/rtalogo.gif" },
                new Institute { Id = 2, Name = "QLD RTA", Detail = "Test 12 Detail", LogoImageSource = "" },
                new Institute { Id = 3, Name = "TAS RTA", Detail = "Test 13 Detail", LogoImageSource = "" }
            };
        }

        public IEnumerable<Institute> GetAll()
        {
            return Publishers;
        }

        public Institute GetById(int id)
        {
            return Publishers.FirstOrDefault(p => p.Id == id);
        }
    }
}