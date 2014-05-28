using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategySample.Quack;

namespace StrategySample.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm an exotic duck.");
        }
    }
}
