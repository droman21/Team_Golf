using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Golf.Models;

namespace Team_Golf.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(Review review);
        void Update(Review review);
    }
}
