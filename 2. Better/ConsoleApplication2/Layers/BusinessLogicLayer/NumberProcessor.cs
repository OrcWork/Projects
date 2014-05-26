using System;
using Microsoft.Practices.Unity;

namespace ConsoleApplication2
{
    public class NumberProcessor : INumberProcessor
    {
        private readonly IUnityContainer _container;

        public NumberProcessor(IUnityContainer container)
        {
            _container = container;
        }

        public Double Multyply(double number)
        {
            // Здесь теперь тоже провайдер достаётся из контейнера
            var coefficientProvider = _container.Resolve<ICoefficientProvider>();
            var coef = coefficientProvider.GetCoefficient();

            return number * coef;
        }
    }
}