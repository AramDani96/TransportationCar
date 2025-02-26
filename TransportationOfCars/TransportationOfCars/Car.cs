using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOfCars
{
    internal class Car
    {
        public int IdCar { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public CarType CarType { get; set; }
        public int Year { get; set; }

        public double GetCoefficientCarType()
        {
            return CarType.CoefficientType;
        }

    }
}
