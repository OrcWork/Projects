using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.HeavyWeapon
{
    class NoHeavyWeaponInstall : IHeavyWeapon
    {
        public void InstallHeavyWeapon()
        {
            Console.WriteLine("Тяжелое оружее не установленно на Mech");
        }
    }
}
