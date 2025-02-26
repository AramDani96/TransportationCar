using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOfCars
{
    internal interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(Func<T, bool> func, T updeteObject);
        public void Delete(Func<T,bool> func);
        public T GetByPredicate(Func<T,bool> func);
    }
}
