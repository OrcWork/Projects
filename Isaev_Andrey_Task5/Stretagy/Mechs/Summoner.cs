using Stretagy.HeavyWeapon;
using Stretagy.LightWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.Mechs
{
    class Summoner : MechBase
    {
        public Summoner()
        {
            lightWeapotInstall = new NoLightWeaponInstall();
            heavyWeapotInstall = new NoHeavyWeaponInstall();
        }
        public override void DisplayMech()
        {
            Console.WriteLine("Summoner");
        }
    }
}
