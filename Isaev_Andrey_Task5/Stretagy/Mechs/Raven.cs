using Stretagy.HeavyWeapon;
using Stretagy.LightWeapon;
using Stretagy.MechsMediumWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.Mechs
{
    class Raven : MechBase
    {
        public Raven()
        {
            mediumWeapotInstall = new NoMediumWeaponInstall();
            heavyWeapotInstall = new NoHeavyWeaponInstall();
        }
        public override void DisplayMech()
        {
            Console.WriteLine("Raven");
        }
    }
}
