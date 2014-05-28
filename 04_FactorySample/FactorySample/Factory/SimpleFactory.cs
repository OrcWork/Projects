using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.Cars;

namespace FactorySample.Factory
{
    public class SimpleFactory
    {
        public Car GetCar(string type)
        {
            /*Car car = new Car();

            if (type == "Golf")
                car = new DeutschGolf();
            else if (type == "Passat")
                car = new DeutschPassat();
            else if (type == "Tiguan")
                car = new DeutschTiguan();
            else if (type == "Touareg")
                car = new DeutschTouareg();

            return car;*/
            return null;
        }
    }
}
