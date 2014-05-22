using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deligate
{
  /*  delegate string Del (int x, bool y); //объявление делегата который может вызывать любой метод
                                         // который возвращает тип стринг и принимает два параметра инт и бул
    delegate void DelStat (ref int x);*/

    delegate BaseClass Del (string name);


    class Program
    {
        static void Main(string[] args)
        {
 /*           SomeClass sc = new SomeClass();
            Del del = new Del(sc.Method);//непосредственное создание объект делегата типа Del
            DelStat ds = new DelStat(SomeClass.MethodStat);

            string s = del(10, true); //вызов метода через ссылку del
            Console.WriteLine(s);

            int p = 50;

            ds(ref p);
            Console.WriteLine("p = {0}",p);
            Console.ReadKey();*/
            Del del = new Del(Method);
            BaseClass bs = del("Первое имя");
            Console.WriteLine(bs.name);
            Console.ReadKey();

        }
        static BaseClass Method(string name)
        {
            return new BaseClass(name);
        }
    }
}
/*class SomeClass
{
    public string Method(int x, bool flag)
    {
        return string.Format(x.ToString() + " " + flag.ToString());
    }
    public static void MethodStat(ref int x)
    {
        x *= x;
    }
}*/
class BaseClass
{
    public string name;
        public BaseClass(string name)
    {
        this.name=name;
    }
        public BaseClass()
        {
        }
}

class SomeClass : BaseClass
{

}
