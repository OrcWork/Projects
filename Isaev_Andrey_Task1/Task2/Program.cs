using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите длинну стороны a: ");
                double a = double.Parse(System.Console.ReadLine());


                Console.Write("Введите длинну стороны b: ");
                double b = double.Parse(System.Console.ReadLine());


                System.Console.Write("Введите длинну стороны c: ");
                double c = double.Parse(System.Console.ReadLine());

                if (a > 0 & b > 0 & c > 0)
                {
                    Triangle rnd = new Triangle(a, b, c);
                    rnd.Area = 0;
                    rnd.Perimeter = 0;
                    if (rnd.Area != 0)
                    {
                        Console.WriteLine("Площадь треугольника равна: " + rnd.Area);
                        Console.WriteLine("Периметр треугольника равен: " + rnd.Perimeter);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное значение сторон треугольника, площадь неможет быть вычисленна, та как это не является треугольником");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение стороны треугольника");
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
