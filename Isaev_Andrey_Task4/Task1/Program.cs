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

            List<int> summ = new List<int>() { 12, 20, 23, 167, 5 }; //задаем массив

            foreach (int sum in summ)
            {
                Console.Write(" " + sum);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Сумма элементов массива равна: " + summ.GetSum()); // используем расширяющий метод для summ
            Console.ReadKey();


        }
    }
}
