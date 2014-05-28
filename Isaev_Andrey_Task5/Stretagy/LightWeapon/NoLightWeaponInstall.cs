using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.LightWeapon
{
    class NoLightWeaponInstall : ILightWeapon
    {
        public void InstallLightWeapon()
        {
            Console.WriteLine("Легкое оружее не установленно на Mech");
        }
    }
}
