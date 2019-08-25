using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppRestaurant.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Edit(T obj);
        void Delete(int id);
        List<T> List();
        T getbyId(int? id);
    }
}
