using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class MemoryPersonAccessor : IPersonAccessor
    {

        //Задаем список в котором будут храниться все значения
        static ArrayList name = new ArrayList() { "Name1", "Name2", "Name3", "Name4" };
        static ArrayList value = new ArrayList() { "Value1", "Value2", "Value3", "Value4" };
        Exception notFoundExcaption = new Exception("Имя не найдено");
        string str = "";
        // Вывод всех значений в списках
        public string GetAll()
        {
            
            for (int i = 0; i < name.Count; i++)
            {
                str = str + name[i] + "=" + value[i] + "\n";
            }
            return str;
        }

        //Поиск значения по имени
        public string GetByName(string nm)
        {

            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    str = str + name[i] + "=" + value[i]+"\n";
                }
            }
          /*  if (!name.Contains(nm))
            {
               // str = "Имя не найдено";
                throw notFoundExcaption();
            }*/
            if (!name.Contains(nm)) throw notFoundExcaption;

            return str;
        }

        //Перезапись значения в списке
        public string Update(string nm, string vl)
        {
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    value[i] = vl;
                    str = "Значение перезаписано";
                }
            }
            if (!name.Contains(nm)) throw notFoundExcaption;
 /*           {
                str = "Имя не найдено";
            }*/
            return str;
        }

        //Удаление значения из списка
        public string Delete(string nm)
        {
            if (!name.Contains(nm)) throw notFoundExcaption;
 /*           {
                str = "Имя не найдено";
            }*/
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    name.RemoveAt(i);
                    value.RemoveAt(i);
                    str = "Значение удалено";
                }
            }
            return str;
        }

        //Добавление нового значения в список
        public string Add(string nm, string vl)
        {
            name.Add(nm);
            value.Add(vl);
            str = "Новое значение добавлено";
            return str;
        }

    }
}
