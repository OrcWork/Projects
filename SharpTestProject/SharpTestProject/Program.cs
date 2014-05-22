using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SharpTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Foo().Hello();
//            Foo f = new Foo();
  //          f.Hello();
            Type type = System.Type.GetType("Foo");
            var foo = Activator.CreateInstance(type);
            foo.GetType().GetMethod("Hello").Invoke(foo, null);
        }
    }
}
