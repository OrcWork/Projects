using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactorySample.PartsFactory;

namespace FactorySample.Cars
{
    public class Golf : Car
    {
        private CarPartsFactory _factory;

        public Golf(CarPartsFactory factory)
        {
            Name = "Golf";
            Body = "Hatchback";

            _factory = factory;
        }

        public override void Configure()
        {
            Console.WriteLine("Configuring {0}", Name);
            Console.WriteLine("Body is: {0}", Body);

            Engine = _factory.CreateEngine();
            PaintColor = _factory.CreatePaint();
            Wheels = _factory.CreateWheels();
        }
    }
}
