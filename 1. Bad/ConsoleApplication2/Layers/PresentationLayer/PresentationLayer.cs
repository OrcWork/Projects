using System;

namespace ConsoleApplication2
{
    public class PresentationLayer
    {
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

            var numberProcessor = new NumberProcessor();
            var result = numberProcessor.Multyply(number);

            Console.WriteLine("Результат: " + result.ToString());
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }
    }
}