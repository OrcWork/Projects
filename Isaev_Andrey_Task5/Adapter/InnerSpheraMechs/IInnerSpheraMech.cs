using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.InnerSpheraMechs
{
    interface IInnerSpheraMech
    {
        string MechName { get; set; }

        void Weapon();
        void Type();
        void Stratage();
    }
}
