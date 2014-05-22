using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    static class ExtantionClass
    {
        //Расширяющий метод для summ, который находит сумму элементов заданного массива
        static public int GetSum(this List<int> summ)
        {
            int s = 0;
            foreach (int sum in summ)
                s += sum;
            return s;
        }
    }
}
