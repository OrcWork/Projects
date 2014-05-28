using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample.WashingMachine
{
    class WaterManagingSubsystem
    {
        public void FillWater(int litres)
        {
            Console.WriteLine("Fill with {0} litres of water", litres);
        }

        public void EmptyWater()
        {
            Console.WriteLine("Empty water tank");
        }
    }
}
