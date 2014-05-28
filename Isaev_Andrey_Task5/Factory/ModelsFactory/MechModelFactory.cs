using Factory.Mechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ModelsFactory
{
    public abstract class MechModelFactory
    {
        public abstract Light AddLightMech();
        public abstract Medium AddMediumMech();
        public abstract Heavy AddHeavyMech();
        public abstract Assault AddAssaultMech();
    }
}
