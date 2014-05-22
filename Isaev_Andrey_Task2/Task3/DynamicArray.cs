using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task3
{
    class DynamicArray
    {
        static int[] array = new int[1];
        // В этом конструкторе создаем массив с 8 элементами
        public DynamicArray()
        {
                array = new int[8];
        }
        // Создаем массив с заданным количеством элементов
        public DynamicArray(int c)
        {
            array = new int[c];
        }

        // В конструктор передаем коллекцию и перезаписываем ей массив
        public DynamicArray(Array array1)
        {
            NumClass nc = new NumClass();
            array = new int[array1.Length];

            int j = 0;
            foreach (int i in nc)
            {
                array[j] = i;
                j++;
            }
        }
        //Без него метод AddRange корректно работать не будет
        public DynamicArray(string s)
        {
        }

        // Метод добавления элемента в массив
        public void Add(int value)
        {
            int c = 0;
            // проверяем массив array на наличие нулевых значений
            // если нахотит ноль в массиве то вместо него подставляет значение value
            for (int i = 0; i < array.Count(); i++)
            {

                if (array[i] == 0)
                {
                    array[i] = value;
                    break;
                }
                else
                {
                    c++;
                }
            }
            if (c == array.Count())
            {
                //Записываем все значения из массива array в массив array2
                int[] array2 = new int[array.Count() * 2];
                for (int j = 0; j < array.Count(); j++)
                {
                    array2[j] = array[j];
                }
                array2[array.Count()] = Convert.ToInt32(value);// присваиваем новому элементу массива значение value
                array = array2;// массив array2 становится массивом array
            }
        }

        // Метод добавляющий в конец массива коллекцию, реализующую интерфейс IEnumerable
        public void AddRange(Array array1)
        {
            int[] array3 = new int[array.Count() + array1.Length];
            NumClass nc = new NumClass();
            for (int j = 0; j < array.Count(); j++)
            {
                array3[j] = array[j];
            }
            int q = 0;
            foreach (int i in nc)
            {
                array3[q + array.Count()] = i;
                q++;
            }
            array = array3;
        }

        // Метод для удаления элемента из массива
        public bool Remove(int value)
        {
            bool a = false;
            if (value >= 0 & value < array.Count())
            {
                array[value] = 0;
                a = true;
            }
            return a;
        }

        // Метод для вставки элемента в массив
        public bool Insert(int value1, int value2)
        {
            bool a = false;
            if (value1 >= 0 & value1 < array.Count())
            {
                array[value1] = value2;
                a = true;
            }
            return a;
        }

        // Свойство длинна массива
        private int length;
        public int Length
        {
            get { return array.Count(); }
            set { ; }
        }

        // Свойство реальная длинна массива
        private int capacity;
        private string s;
        public int Capacity
        {
            get
            {
                int c = 0;
                for (int i = 0; i < array.Count(); i++)
                {
                    if (array[i] != 0)
                        c++;
                }
                return c;
            }
            set { ; }
        }
        // Метод вывода массива на экран
        public void Print()
        {
            foreach (int value1 in array)
            {
                Console.WriteLine(value1);
            }
            Console.ReadKey();
        }

        // Ошибка при выходе за пределы массива
        internal void ArgumentOutOfRangeException()
        {
            Console.WriteLine("Указанный номер элемента выходит за границы массива");
        }
        // Ошибка при некорректном вводе в консоль
        internal void ConsoleReadEcxeption()
        {
            Console.WriteLine("Введено некорректное значение");
        }
    }
}
