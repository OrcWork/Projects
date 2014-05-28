using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mechs
{
    class LightFireMoth : Light
    {
        public LightFireMoth()
        {
            Console.WriteLine("FireMoth добавлен в группу");
        }
    }
}
