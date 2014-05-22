using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyORM
{
    [Attribut(TableName = "Person")]
    class Person
    {
        //public static object Name;
        [Attribut(Colum1 = "Name")]
        public static string name;// { get; set; }

        [Attribut(Colum2 = "Value")]
        public string value;// { get; set; }

       // MyORMDBPersonAccesor mbpa = new MyORMDBPersonAccesor();
        //mbpa.GetAll(typeof(Person));
    }
}
