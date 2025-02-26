using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOfCars
{
    internal class AdminService<T> : IRepository<T>,ICalculate
    {
        private List<T> _entitiesList = new List<T>();
        public decimal Price { get; private set; }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity is null");
            }

            _entitiesList.Add(entity);
        }

        public void Delete(Func<T,bool> func)
        {
            var result = GetByPredicate(func);

            if (result == null)
            {
                throw new Exception("Entity not found");
            }

            _entitiesList.Remove(result);
        }

        public T GetByPredicate(Func<T, bool> func)
        {
           var result = _entitiesList.FirstOrDefault(func);

            if (result == null)
            { 
            throw new Exception("Entity not found");
            }

            return result;
        }

        public void Update(Func<T, bool> func, T updeteObject)
        {
            if (updeteObject == null)
            {
                throw new Exception("Update object cannot be null");
            }
            var result = GetByPredicate(func);

            int index = _entitiesList.IndexOf(result);

            _entitiesList[index] = updeteObject;
        }

        public decimal CalculateTranspationPrice(CityToCity cityToCity, Car car, container container)
        {
            Price = (decimal)cityToCity.PriceTransportation;
            Price *= (decimal)car.CarType.CoefficientType;

            if (container.IsOpen)
            {
                Price += (decimal)container.CoefficientConteiner;
            }
            else
            {
                Price *= (decimal)container.CoefficientConteiner;
            }

            return Price;
        }
    }
}
