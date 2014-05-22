using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task2
{
    class Person
    {
        static ArrayList inoffice = new ArrayList();
        public event EventInOffice Action;

        //Здесь заполняется список теми кто приходит в офис
        public void PersonInOffice(string n)
        {
            inoffice.Add(n);
        }
        // метод который вызывается когда кто-то входит
        public void Hellow(DayTimeEventArgs e)
        {
            // Если время между 12 и 17 то все говорят добрый день
            if (e.TimeNow.Hour >= 12 & e.TimeNow.Hour < 17)
            {
                if (inoffice.Count != 1)
                {
                    for (int i = 0; i < inoffice.Count - 1; i++)
                    {
                        Console.WriteLine("Добрый день сказал " + inoffice[i]);
                    }
                }
            }
            // Если время между 17 и 24 то все говорят добрый вечер
            if (e.TimeNow.Hour >= 17 & e.TimeNow.Hour < 24)
            {
                if (inoffice.Count != 1)
                {
                    for (int i = 0; i < inoffice.Count - 1; i++)
                    {
                        Console.WriteLine("Добрый вечер сказал " + inoffice[i]);
                    }
                }
            }
            // Если время между 0 и 12 то все говорят доброе утро
            if (e.TimeNow.Hour >= 0 & e.TimeNow.Hour < 12)
            {
                if (inoffice.Count != 1)
                {
                    for (int i = 0; i < inoffice.Count - 1; i++)
                    {
                        Console.WriteLine("Доброе утро сказал " + inoffice[i]);
                    }
                }
            }

        }
        //метод который вызывается при уходе кого-то из офиса
        public void Goodbye(DayTimeEventArgs e)
        {
            for (int i = 0; i < inoffice.Count; i++)
            {
                Console.WriteLine(inoffice[i] + " покидает офис");
                for (int j = i + 1; j < inoffice.Count; j++)
                {
                    Console.WriteLine("Пока сказал " + inoffice[j]);
                }

            }


        }


        public void DoEvent(DayTimeEventArgs e)//генерация события
        {
            if (Action != null)
                Action(e);//Запуск события
        }

    }
}
