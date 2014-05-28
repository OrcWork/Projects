using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Mech
{
    class Shoot
    {
        public void Shooting(int value)
        {
            Console.WriteLine("Количество оружий, которые стреляют {0}", value);
        }
    }
}
