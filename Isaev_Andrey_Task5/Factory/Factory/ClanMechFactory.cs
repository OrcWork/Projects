using Factory.MechTypes;
using Factory.ModelsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    class ClanMechFactory : MechFactory
    {
        protected override Mech CreateMech(string type)
        {
            MechModelFactory factory = new ClanMechModelFactory();
            if (type == "LightMech")
                return new LightMech(factory);
            else if (type == "MediumMech")
                return new MediumMech(factory);
            else if (type == "HeavyMech")
                return new HeaveMech(factory);
            else if (type == "AssaultMech")
                return new AssaultMech(factory);
            return null;
        }
    }
}
