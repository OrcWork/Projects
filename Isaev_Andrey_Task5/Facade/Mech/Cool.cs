using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Mech
{
    class Cool
    {
        public void Cooling(int time)
        {
            Console.WriteLine("Время необходимое на охлаждение силовой установки: {0} секунд", time);
        }
    }
}
