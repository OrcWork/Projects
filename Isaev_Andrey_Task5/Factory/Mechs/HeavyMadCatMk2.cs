using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mechs
{
    class HeavyMadCatMk2 : Heavy
    {
        public HeavyMadCatMk2()
        {
            Console.WriteLine("MadCatMk2 добавлен в группу");
        }
    }
}
