using System;

namespace FacadeSample.WashingMachine
{
    class Dryer
    {
        public void Dry(int seconds, int intensity)
        {
            Console.WriteLine("Drying {0} seconds with intensity {1}", seconds, intensity);
        }
    }
}
