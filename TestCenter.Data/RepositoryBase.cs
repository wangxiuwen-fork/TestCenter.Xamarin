using System.Collections.Generic;

namespace TestCenter.Data
{
    public interface RepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}