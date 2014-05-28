using Factory.MechTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    abstract class MechFactory
    {
        public Mech GetMech(string type)
        {
            Mech mech = CreateMech(type);
            mech.TeamConfigurate();
            mech.Choose();
            return mech;
        }
        protected abstract Mech CreateMech(string type);
    }
}
