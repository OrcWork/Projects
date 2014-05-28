using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.HeavyWeapon
{
    class HeavyWeaponInstall : IHeavyWeapon
    {
        public void InstallHeavyWeapon()
        {
            Console.WriteLine("Тяжелое оружее установленно на Mech");
        }
    }
}
