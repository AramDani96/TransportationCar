using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationOfCars
{
    internal class CityToCity
    {
        public Cities FirstCity { get; set; }
        public Cities SecondCity { get; set; }
        public double Distance { get; set; }

        public double PriceTransportation { get; set; }

    }
}