using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Введите координату X центра окружности: ");
                double x = double.Parse(System.Console.ReadLine()); ;


                Console.Write("Введите координату Y центра окружности: ");
                double y = double.Parse(System.Console.ReadLine()); ;


                System.Console.Write("Введите радиус окружности R: ");
                double r = double.Parse(System.Console.ReadLine());
                if (r > 0)
                {

                    Round rnd = new Round(r);
                    rnd.Area = 0;
                    rnd.Lenght = 0;
                    Console.WriteLine("Площадь окружности равна: " + rnd.Area);
                    Console.WriteLine("Длинна окружности равна: " + rnd.Lenght);
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение радиуса");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Console.WriteLine(e.Message);
            }



            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();

        }
    }
}
