using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategySample.Fly;

namespace StrategySample.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck!");
        }
    }
}
