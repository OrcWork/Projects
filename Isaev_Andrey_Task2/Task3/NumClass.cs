using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task3
{
    class NumClass : IEnumerable, IEnumerator
    {
        int[] array = { 12, 13, 1, 4 };
        int index = -1;

        
    /*    IEnumerator IEnumerable.GetEnumerator()
        {
            //return array.GetEnumerator();
        }*/

        // Реализуем интерейс IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        //Здесь передаем в конструктор коллекцию, где она станет массивом
        public void Method()
        {
            DynamicArray da = new DynamicArray(array);

        }
        // Передаем коллекцию в метод AddRange где ее добавляем в конец массива
        public void Method2()
        {
            string s = "";
            DynamicArray da = new DynamicArray(s);
            da.AddRange(array);
           
        }

        // Реализуем интерфейс IEnumerator
        public bool MoveNext()
        {
            if (index == array.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return array[index];
            }
        }
 
    }
}
