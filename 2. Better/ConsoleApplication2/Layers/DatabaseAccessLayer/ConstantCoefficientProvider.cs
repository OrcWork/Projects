using System;

namespace ConsoleApplication2
{
    public class ConstantCoefficientProvider : ICoefficientProvider
    {
        public Double GetCoefficient()
        {
            return 42;
        }
    }
}