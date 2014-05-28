using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mechs
{
    class HeavyRifleman : Heavy
    {
        public HeavyRifleman()
        {
            Console.WriteLine("Rifleman добавлен в группу");
        }
    }
}
