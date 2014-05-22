using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();

            Console.WriteLine("Введите первое значение");
            string value1 = Console.ReadLine();

            Console.WriteLine("введите знак операции");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе значение");
            string value2 = Console.ReadLine();

            op.InitWithStrings(value1, operation, value2);

            Console.WriteLine("Ответ");
            Console.WriteLine(op.ToString());
            Console.WriteLine(op.Total());

            Console.ReadKey();


        }
    }
}
