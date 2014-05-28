using Stretagy.LightWeapon;
using Stretagy.MechsMediumWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.Mechs
{
    class TimberWolf : MechBase
    {
        public TimberWolf()
        {
            lightWeapotInstall = new NoLightWeaponInstall();
            mediumWeapotInstall = new NoMediumWeaponInstall();
        }
        public override void DisplayMech()
        {
            Console.WriteLine("TimberWolf");
        }
    }
}
