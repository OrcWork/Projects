using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ClanMechs
{
    interface IClanMech
    {
        string MechName { get; set; }

        void Weapon();
        void Type();
        void Honor();
    }
}
