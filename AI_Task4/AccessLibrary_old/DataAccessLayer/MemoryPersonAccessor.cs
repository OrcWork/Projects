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

        // Вывод всех значений в списках
        public string GetAll()
        {
            string str = "";
            for (int i = 0; i < name.Count; i++)
            {
                str = str + name[i] + "=" + value[i] + "\n";
            }
            return str;
        }

        //Поиск значения по имени
        public string GetByName(string nm)
        {
            string str = "";
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    str = str + name[i] + "=" + value[i]+"\n";
                }
            }
            if (!name.Contains(nm)) throw notFoundExcaption;
            return str;
        }

        //Перезапись значения в списке
        public void Update(string nm, string vl)
        {
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    value[i] = vl;
                }
            }
            if (!name.Contains(nm)) throw notFoundExcaption;
        }

        //Удаление значения из списка
        public void Delete(string nm)
        {
            if (!name.Contains(nm)) throw notFoundExcaption;
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    name.RemoveAt(i);
                    value.RemoveAt(i);
                }
            }
        }

        //Добавление нового значения в список
        public void Add(string nm, string vl)
        {
            name.Add(nm);
            value.Add(vl);
        }



        public string GetAllORM(Type t)
        {
            throw new NotImplementedException();
        }


        public string GetByNameORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void UpdateORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }

        public void DeleteORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void AddORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }
    }
}
