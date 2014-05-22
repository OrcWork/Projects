using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Это ссылка на объек, а есть еще ссылки на типы
            SomeClass sc = new SomeClass();//ссылка на класс SomeClass. Ссылка sc указывает на объект SomeClass. Можем вызывать его поля, методы и тд.
             */
         /*   //Создаем ссылку на тип
            Type t = typeof(short);

            byte b = 10;
            Type b_info = b.GetType();// получаем тип объекта в нашем случае byte
            Console.WriteLine(b_info);
            Console.ReadKey();

            Type tt = Type.GetType("System.Int32");
           */

            Type t = Type.GetType("SomeClass");
            ShowMetaData(t);
        }

        static void ShowMetaData(Type t)
        {
            FieldInfo[] F = t.GetFields();
            foreach (FieldInfo info in F)
            {
                Console.WriteLine(info.Name);
            }
             
            Console.ReadLine();
        }
    }

    interface ISomeInterface
    {
        String SomeMethod(bool flag);
    }

    class BaseClass
    {
        public bool flag;
    }

    class SomeClass : BaseClass, ISomeInterface
    {
        int iii;
        public int Iii
        {
            get { return iii;}
            set { iii = value; }
        }

        public string SomeMethod(bool flag)
        {
            return flag.ToString();
        }
    }
}
