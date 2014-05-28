using Factory.ModelsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.MechTypes
{
    class HeaveMech : Mech
    {
        private MechModelFactory _factory;
        public HeaveMech(MechModelFactory factory)
        {
            _factory = factory;
        }
        public override void TeamConfigurate()
        {
        Heavy = _factory.AddHeavyMech();
        }
    }
}
