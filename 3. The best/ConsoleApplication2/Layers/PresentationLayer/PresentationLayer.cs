using System;

namespace ConsoleApplication2
{
    public class PresentationLayer : IPresentationLayer
    {
        private readonly INumberProcessor _numberProcessor;

        /// <summary>
        /// Самый правильный путь — передавать в конструкторе какие объекты нам нужны из контейнера
        /// 
        /// Во-первых, тогда мы избавляемся от явного указания контейнера, что уже само по себе хорошо,
        /// в случае, например, если мы захотим UnityContainer поменять на NInject или ещё что-нибудь
        /// 
        /// Во-вторых, таким образом сразу видно, какие объекты использует этот класс, то есть,
        /// сразу виден контракт класса, что очень удобно
        /// 
        /// Никакой магии здесь нет, контейнер просто подставляет по типу то, что лежит в нём
        /// Если тип не зарегистрирован в контейнере, будет ошибка
        /// </summary>
        public PresentationLayer(INumberProcessor numberProcessor)
        {
            _numberProcessor = numberProcessor;
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

            // Теперь здесь мы используем объект, полученный в конструкторе
            var result = _numberProcessor.Multyply(number);

            Console.WriteLine("Результат: " + result.ToString());
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }
    }
}