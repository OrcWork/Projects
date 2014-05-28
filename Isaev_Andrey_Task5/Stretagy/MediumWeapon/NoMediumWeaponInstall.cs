using Stretagy.MediumWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.MechsMediumWeapon
{
    class NoMediumWeaponInstall : IMediumWeapon
    {
        public void InstallMediumWeapon()
        {
            Console.WriteLine("Среднее оружее не установленно на Mech");
        }
    }
}
