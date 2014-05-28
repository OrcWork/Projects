using Factory.Mechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.MechTypes
{
   public abstract class Mech
    {
        protected Light Light;
        protected Medium Medium;
        protected Heavy Heavy;
        protected Assault Assault;

        public abstract void TeamConfigurate();
        public void Choose()
        {
            Console.WriteLine("Mech для сражения выбран");
        }
    }
}
