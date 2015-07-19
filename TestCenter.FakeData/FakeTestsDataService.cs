using System;
using System.Collections.Generic;
using TestCenter.Data;
using TestCenter.Model;

namespace TestCenter.FakeData
{
    public class FakeTestsDataService : TestsDataService
    {
        public IEnumerable<Test> GetAll()
        {
            throw new NotImplementedException();
        }

        public Test GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
