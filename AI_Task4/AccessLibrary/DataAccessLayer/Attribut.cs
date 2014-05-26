using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
     public class Attribut : System.Attribute
    {
        public String TableName;
        public String Colum1;
        public String Colum2;

        public void Attribute()
        {
            TableName = "";
            Colum1 = "";
            Colum2 = "";
        }
    }
}
