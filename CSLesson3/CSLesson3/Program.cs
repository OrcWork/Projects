using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип машины");

            string type = Console.ReadLine();

            Car chosenCar = GetCarByType(type);

            Console.WriteLine("Вы выбоали");
            Console.WriteLine(chosenCar.ToString());

            Console.WriteLine("Поехали");
            chosenCar.Drive();
            Console.WriteLine(chosenCar.ToString());

            Console.ReadKey();
        }

        static Car GetCarByType(string type)
        {
            switch (type)
            {
                case "VAZ":
                    return new Vaz();
                case "Lambo":
                    return new Lamborgini();
                case "Ferrari":
                    return new Ferrari();

                default:
                    return null;
            }
        }
    }
}
