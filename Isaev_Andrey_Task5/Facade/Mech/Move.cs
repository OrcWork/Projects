using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Mech
{
    class Move
    {
        public void Movement (int speed)
        {
            Console.WriteLine("Прередвигаться со скоростью {0} км/ч", speed);
        }
        public void Stop()
        {
            Console.WriteLine("Останвиться");
        }
    }
}
