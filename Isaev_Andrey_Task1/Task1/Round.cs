using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Round
    {

        private double area;
        private double lenght;
        public static double radius;


        public Round(double r)
        {

            radius = r;
        }


        public double Area
        {
            get { return area; }
            set { area = 3.1416 * radius * radius; }
        }


        public double Lenght
        {
            get { return lenght; }
            set { lenght = 2 * 3.1416 * radius; }
        }

    }
}
