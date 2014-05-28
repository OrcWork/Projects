using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ClanMechs
{
    class TimberWolf : IClanMech
    {
        public string MechName { get; set; }

        public void Weapon()
        {
            Console.WriteLine("Оружее ближнего и дальнего радиуса действия");
        }

        public void Type()
        {
            Console.WriteLine("Штурмовой Mech");
        }

        public void Honor()
        {
            Console.WriteLine("Честь его второе имя");
        }
    }
}
