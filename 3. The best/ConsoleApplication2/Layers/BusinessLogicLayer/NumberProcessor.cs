using System;

namespace ConsoleApplication2
{
    public class NumberProcessor : INumberProcessor
    {
        private readonly ICoefficientProvider _coefficientProvider;

        public NumberProcessor(ICoefficientProvider coefficientProvider)
        {
            _coefficientProvider = coefficientProvider;
        }

        public Double Multyply(double number)
        {
            // Здесь теперь тоже провайдер получаем из конструктора
            var coef = _coefficientProvider.GetCoefficient();

            return number * coef;
        }
    }
}