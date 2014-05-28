using Factory.ModelsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.MechTypes
{
     class AssaultMech : Mech
    {
        private MechModelFactory _factory;
        public AssaultMech(MechModelFactory factory)
        {
            _factory = factory;
        }
        public override void TeamConfigurate()
        {
        Assault = _factory.AddAssaultMech();
        }
    }
}
