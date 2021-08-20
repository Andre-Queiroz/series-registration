using System.Collections.Generic;

namespace series_registration.Interfaces
{
    public interface IRepository<T> // T is a generic type
    {
        List<T> List();

        T GetById(int id);

        void Add(T entity);

        void Delete(int id);

        void Update(int id, T entity);

        int GetNextId();
    }
}
