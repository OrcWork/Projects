using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategySample.Fly;
using StrategySample.Quack;

namespace StrategySample.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm a wooden duck!");
        }
    }
}
