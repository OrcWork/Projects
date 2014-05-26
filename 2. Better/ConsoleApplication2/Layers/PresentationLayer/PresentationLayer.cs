using System;
using Microsoft.Practices.Unity;

namespace ConsoleApplication2
{
    public class PresentationLayer : IPresentationLayer
    {
        private readonly IUnityContainer _container;

        /// <summary>
        /// Обратите внимание, что мы не вызывали конструктор сами
        /// Его вызывает сам контейнер, сам обнаруживает, что в качестве параметра требуется
        /// контейнер, и сам же передаёт себя туда.
        /// Очень удобно.
        /// </summary>
        /// <param name="container"></param>
        public PresentationLayer(IUnityContainer container)
        {
            _container = container;
        }

        public void DoWork()
        {
            Console.Write("Введите число: ");
            var strNumber = Console.ReadLine();
            
            Double number;
            if (!Double.TryParse(strNumber, out number))
            {
                Console.WriteLine("Ошибка: не удалось распознать число!");
                Console.ReadKey();
                return;
            }

            // Теперь здесь мы получаем объект бизнес-логики из контейнера
            var numberProcessor = _container.Resolve<INumberProcessor>();
            var result = numberProcessor.Multyply(number);

            Console.WriteLine("Результат: " + result.ToString());
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }
    }
}