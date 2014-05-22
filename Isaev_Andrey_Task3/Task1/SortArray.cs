using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    
    class SortArray
    {
        

        public void LenghtSort(string[] arr)
        {
            string buf;
            Array.Sort(arr);//сортировка по алфавиту

            // пузырьковая сортировка
            for (int i = arr.Count() - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        buf = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buf;
                    }
                }

            }

            //вывод отсортированного массива
            for (int d = 0; d < arr.Length; d++)
            {
                Console.WriteLine("   [{0}] : {1}", d, arr[d]);
            }
        }
    }
}
