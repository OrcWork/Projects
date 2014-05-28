using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mechs
{
    class LightRaven : Light
    {
        public LightRaven()
        {
            Console.WriteLine("Raven добавлен в группу");
        }
    }
}
