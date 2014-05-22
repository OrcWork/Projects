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
            int j = -1;
            int k = 0;
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = n;
            Console.Write("Введите номер выбывающего: ");
            int m = Int32.Parse(Console.ReadLine());
            bool[] a = new bool[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = true;
            }
            Console.WriteLine("Элементы выбывали в след порядке: ");
            while (n1 > 1)
            {
                j++;
                if (j > n - 1) j = 0;
                if (a[j]) k++;
                if (k == m)
                {
                    a[j] = false;
                    k = 0;
                    Console.Write(j + 1 + " ");
                    n1 = n1 - 1;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (a[i] == true)
                {
                    int x = i + 1;
                    Console.WriteLine("Оставшийся элемент: " + x);
                }
            }
            Console.ReadLine();
        }
    }
}
