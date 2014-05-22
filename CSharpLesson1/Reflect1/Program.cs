using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflect1
{
    [Example(StringValue = "This is a string.")]
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(Program);
            foreach (object attrib in info.GetCustomAttributes(true))
            {
                Console.WriteLine(attrib.ToString());
                Console.ReadKey();
            }
        }
    }


    public class ExampleAttribute : Attribute
    {
        private string stringVal;

        public ExampleAttribute()
        {
            stringVal = "This is the default string.";
        }

        public string StringValue
        {
            get { return stringVal; }
            set { stringVal = value; }
        }
    }
}
