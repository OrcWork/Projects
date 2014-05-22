using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    delegate void Del(string[] array);
    class Program
    {
        static void Main(string[] args)
        {
            //задаем массив
            string[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
            SortArray sa = new SortArray();
            Del del = new Del(sa.LenghtSort);
            del(array);//вызываем делегат в который передаем массив array
            Console.ReadKey();
        }

    }
}
