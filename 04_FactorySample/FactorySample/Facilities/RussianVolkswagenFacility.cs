using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Cars;
using FactorySample.PartsFactory;

namespace FactorySample.Facilities
{
    class RussianVolkswagenFacility : VolkswagenFacility
    {
        protected override Car CreateCar(string type)
        {
            CarPartsFactory factory = new RussianCarPartsFactory();

            if (type == "Golf")
                return new Golf(factory);
            else if (type == "Passat")
                return new Passat(factory);
            else if (type == "Tiguan")
                return new Tiguan(factory);
            else if (type == "Touareg")
                return new Touareg(factory);

            return null;
        }
    }
}
