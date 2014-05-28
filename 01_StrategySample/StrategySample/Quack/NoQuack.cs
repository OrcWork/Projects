using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
