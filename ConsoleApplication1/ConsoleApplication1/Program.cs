using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Количество секунд в часе
            const ulong SecondsInDay = 60 * 60 * 24;

            ulong Seconds = 0;
            // Ожидаем корректного ввода
            while (Seconds == 0)
            {
                // Введите время в секундах в заданном диапазоне:
                Console.Write("Введите время в секундах ");
                Console.WriteLine("(от {0} до {1}):",
                   ulong.MinValue + 1, ulong.MaxValue);
                try
                {
                    // Считываем введенное время и преобразуем его в ulong
                    Seconds = Convert.ToUInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    // Ошибка ввода
                    Console.WriteLine(ex.Message + " Попробуйте снова!!!\n");
                }
            }

            // Вычисляем и выводим количество дней
            Console.WriteLine("Дней = {0}", Seconds / SecondsInDay);
            // Отбрасываем дни
            Seconds %= SecondsInDay;
            // Вычисляем и выводим количество часов
            Console.WriteLine("Часов = {0}", Seconds / 3600);
            // Отбрасываем часы
            Seconds %= 3600;
            // Вычисляем и выводим количество минут
            Console.WriteLine("Минут = {0}", Seconds / 60);
            // Вычисляем и выводим количество секунд
            Console.WriteLine("Секунд = {0}", Seconds % 60);

            // Ожидаем нажатия клавиши Enter
            Console.Write("\nНажмите Enter...");
            Console.Read();
        }
    }
}
