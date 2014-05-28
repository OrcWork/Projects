using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.LightWeapon
{
    class LightWeaponInstall : ILightWeapon
    {
        public void InstallLightWeapon()
        {
            Console.WriteLine("Легкое оружее установленно на Mech");
        }
    }
}
