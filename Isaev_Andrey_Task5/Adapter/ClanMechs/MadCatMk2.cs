using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ClanMechs
{
    class MadCatMk2 : IClanMech
    {
        public string MechName { get; set; }

        public void Weapon()
        {
            Console.WriteLine("Тяжелое оружее дальнего радиуса действия");
        }

        public void Type()
        {
            Console.WriteLine("Тяжелый Mech");
        }

        public void Honor()
        {
            Console.WriteLine("Всегда сражается с честью");
        }
    }
}
