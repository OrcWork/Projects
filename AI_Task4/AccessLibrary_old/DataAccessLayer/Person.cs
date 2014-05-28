using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    [Attribut(TableName = "Person")]
    public class Person
    {
        [Attribut(Colum1 = "Name")]
        public static string name;

        [Attribut(Colum2 = "Value")]
        public string value;
    }
}
