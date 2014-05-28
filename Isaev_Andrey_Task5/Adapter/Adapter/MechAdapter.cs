using Adapter.ClanMechs;
using Adapter.InnerSpheraMechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    class MechAdapter : IClanMech
    {
        private IInnerSpheraMech _innerSphereMech;
        public MechAdapter(IInnerSpheraMech innerSphereMech)
        {
            _innerSphereMech = innerSphereMech;
        }

        public string MechName { get; set; }

        public void Weapon()
        {
            _innerSphereMech.Weapon();
        }

        public void Type()
        {
            _innerSphereMech.Type();
        }

        public void Honor()
        {
            _innerSphereMech.Stratage();
        }
    }
}
