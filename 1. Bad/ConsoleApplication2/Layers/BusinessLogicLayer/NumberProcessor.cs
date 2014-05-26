using System;

namespace ConsoleApplication2
{
    public class NumberProcessor
    {
        public Double Multyply(double number)
        {
            var coefficientProvider = new ConstantCoefficientProvider();
            var coef = coefficientProvider.GetCoefficient();

            return number * coef;
        }
    }
}