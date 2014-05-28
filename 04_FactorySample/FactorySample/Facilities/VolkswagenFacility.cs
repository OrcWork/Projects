using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Cars;
using FactorySample.Factory;

namespace FactorySample.Facilities
{
    abstract class VolkswagenFacility
    {
        public Car GetCar(string type)
        {
            Car car = CreateCar(type);

            car.Configure();
            car.AssembleBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }

        protected abstract Car CreateCar(string type);
    }
}
