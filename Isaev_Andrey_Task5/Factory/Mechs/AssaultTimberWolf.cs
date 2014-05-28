using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mechs
{
    class AssaultTimberWolf : Assault
    {
        public AssaultTimberWolf()
        {
            Console.WriteLine("TimberWolf добавлен в группу");
        }
    }
}
