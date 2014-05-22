using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpLesson
{
    class Program
    {

        static void Main(string[] args)
        {
            Type t = typeof(short);
        }
    }

    interface ISomaInterface
    {
        String SomeMethod(bool flag);
    }
    class BaseClass
    {
        public Boolean flag;
    }
    class SomeClass : BaseClass, ISomaInterface
    {
        int i;


    }
}

