using Factory.Mechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ModelsFactory
{
    class SphereMechModelFactory : MechModelFactory
    {
        public override Mechs.Light AddLightMech()
        {
            return new LightRaven();
        }

        public override Mechs.Medium AddMediumMech()
        {
            return new MediumHunchback();
        }

        public override Mechs.Heavy AddHeavyMech()
        {
            return new HeavyRifleman();
        }

        public override Mechs.Assault AddAssaultMech()
        {
            return new AssaultVictor();
        }
    }
}
