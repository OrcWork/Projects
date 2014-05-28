using Stretagy.HeavyWeapon;
using Stretagy.LightWeapon;
using Stretagy.MediumWeapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stretagy.Mechs
{
   public abstract class MechBase
    {
       protected ILightWeapon lightWeapotInstall;
       protected IMediumWeapon mediumWeapotInstall;
       protected IHeavyWeapon heavyWeapotInstall;

       public MechBase()
       {
           lightWeapotInstall = new LightWeaponInstall();
           mediumWeapotInstall = new MediumWeaponInstall(); ;
           heavyWeapotInstall = new HeavyWeaponInstall();
       }
       public void SetLightWeaponInstall(ILightWeapon newLightWeapotInstall)
       {
           lightWeapotInstall = newLightWeapotInstall;
       }

       public void SetMediumWeaponInstall(IMediumWeapon newMediumWeaponInstall)
       {
           mediumWeapotInstall = newMediumWeaponInstall;
       }

       public void SetHeavyWeaponInstall(IHeavyWeapon newHeavyWeapotInstall)
       {
           heavyWeapotInstall = newHeavyWeapotInstall;
       }

       public void LightWeapon()
       {
           lightWeapotInstall.InstallLightWeapon();
       }
       public void MediumWeapon()
       {
           mediumWeapotInstall.InstallMediumWeapon();
       }
       public void HeavyWeapon()
       {
           heavyWeapotInstall.InstallHeavyWeapon();
       }
       public abstract void DisplayMech();


    }
}
