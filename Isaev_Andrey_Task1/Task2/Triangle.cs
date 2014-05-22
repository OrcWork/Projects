using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Triangle
    {
        private double area;
        private double perimeter;
        public static double aside;
        public static double bside;
        public static double cside;

        public Triangle(double a, double b, double c)
        {
            aside = a;
            bside = b;
            cside = c;
        }


        public double Area
        {
            get { return area; }
            set
            {
                double d = (aside + bside + cside) / 2 * ((aside + bside + cside) / 2 - aside) * ((aside + bside + cside) / 2 - bside) * ((aside + bside + cside) / 2 - cside);
                if (d > 0)
                {
                    area = Math.Sqrt(d);
                }
                ;
            }
        }


        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = aside + bside + cside; }
        }
    }
}
