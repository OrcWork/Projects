using Factory.Mechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ModelsFactory
{
    class ClanMechModelFactory : MechModelFactory
    {
        public override Mechs.Light AddLightMech()
        {
            return new LightFireMoth();
        }

        public override Mechs.Medium AddMediumMech()
        {
            return new MediumGriffin();
        }

        public override Mechs.Heavy AddHeavyMech()
        {
            return new HeavyMadCatMk2();
        }

        public override Mechs.Assault AddAssaultMech()
        {
            return new AssaultTimberWolf();
        }
    }
}
