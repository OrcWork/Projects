using Stretagy.LightWeapon;
using Stretagy.Mechs;
using Stretagy.MediumWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy
{
    class Program
    {
        static void Main(string[] args)
        {
            MechBase raven = new Raven();
            raven.DisplayMech();
            raven.LightWeapon();
            raven.MediumWeapon();
            raven.HeavyWeapon();
            raven.SetMediumWeaponInstall(new MediumWeaponInstall());
            raven.MediumWeapon();

            Console.WriteLine();

            MechBase summoner = new Summoner();
            summoner.DisplayMech();
            summoner.LightWeapon();
            summoner.MediumWeapon();
            summoner.HeavyWeapon();

            Console.WriteLine();

            MechBase timberwolf = new TimberWolf();
            timberwolf.DisplayMech();
            timberwolf.LightWeapon();
            timberwolf.MediumWeapon();
            timberwolf.HeavyWeapon();
            timberwolf.SetMediumWeaponInstall(new MediumWeaponInstall());
            timberwolf.MediumWeapon();
            timberwolf.SetLightWeaponInstall(new LightWeaponInstall());
            timberwolf.LightWeapon();

            Console.ReadKey();
        }
    }
}
