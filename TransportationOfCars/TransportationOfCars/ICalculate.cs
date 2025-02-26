using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOfCars
{
    internal interface ICalculate
    {
        public decimal CalculateTranspationPrice(CityToCity cityToCity, Car car, container container);
    }
}
