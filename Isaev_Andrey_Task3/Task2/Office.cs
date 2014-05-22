using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task2
{
    delegate void EventInOffice(DayTimeEventArgs e);
    class Office
    {
        ArrayList athome = new ArrayList();


        public void OfficeLife()
        {
            athome.Add("Mr. Fox");
            athome.Add("Mr. Wolf");
            athome.Add("Mr. Pony");
            athome.Add("Mr. Crocodile");


            Person person = new Person();
            person.Action += new EventInOffice(person.Hellow);
            DayTimeEventArgs args = new DayTimeEventArgs();
            args.TimeNow = DateTime.Now;
            // Заполняем офис
            for (int i = 0; i < athome.Count; i++)
            {
                Console.WriteLine(athome[i] + " пришел в офис");
                string n = athome[i].ToString();

                person.PersonInOffice(n);

                
                person.DoEvent(args);// вызов события приветствие
            }
            Console.WriteLine(" ");
            person.Action -= person.Hellow;
            person.Action += new EventInOffice(person.Goodbye);
            person.DoEvent(args);//вызов события прощание
        }
    }
}
