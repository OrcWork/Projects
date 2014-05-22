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
            Console.WriteLine("Введите строку, чтобы определить является ли она целым положительным числом");
            string str = Console.ReadLine();
            Console.WriteLine(str.CheckValue());//спомощью расширяемого метода определяем целое ли положительное это число
            Console.ReadKey();
        }
    }
}
