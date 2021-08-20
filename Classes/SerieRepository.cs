using System.Collections.Generic;
using series_registration.Interfaces;

namespace series_registration
{
    // implements a series repository
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> seriesList = new List<Serie>();
        public void Add(Serie entity)
        {
            seriesList.Add(entity);
        }

        public void Delete(int id)
        {
            seriesList[id].MarkAsDeleted();
        }
        public List<Serie> List()
        {
            return seriesList;
        }

        public void Update(int id, Serie entity)
        {
            seriesList[id] = entity;
        }

        public Serie GetById(int id)
        {
            return seriesList[id];
        }

        public int GetNextId()
        {
            return seriesList.Count;
        }

    }
}
