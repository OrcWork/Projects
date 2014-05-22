using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace MyORM
{
    class Menu
    {
        public void MainMenu()
        {
            MyORMDBPersonAccesor morm = new MyORMDBPersonAccesor();
            
            //morm.GetByName(typeof(Person).GetField("name"), typeof(Person));
            //morm.Update(typeof(Person).GetField("name"), typeof(Person));
            //morm.Delete(typeof(Person).GetField("name"), typeof(Person));
            //morm.Add(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"));
            morm.GetAll(typeof(Person));



            //morm.GetByName(typeof(Person));
            //Person p = new Person();
            //morm.GetByName(typeof(p.name));



            //Person p = new Person();
            //morm.GetAll(typeof(Name));
            //morm.GetAll(typeof(p.name.GetType()));
            //morm.GetAll(p.name.GetType());
            //p.GetAll(typeof(Attribut));
            //Type t = Type.GetType("Person");
            //morm.GetAll(t);
            //string pr = p.name;
            //morm.GetAll(typeof(pr));

            //Console.WriteLine(Person.name.GetType());
        }
    }
}
