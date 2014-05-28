using Factory.ModelsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.MechTypes
{
    class MediumMech : Mech
    {
        private MechModelFactory _factory;
        public MediumMech(MechModelFactory factory)
        {
            _factory = factory;
        }
        public override void TeamConfigurate()
        {
        Medium = _factory.AddMediumMech();
        }
    }
}
