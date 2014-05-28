using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.InnerSpheraMechs
{
    class HighLander : IInnerSpheraMech
    {
        public string MechName { get; set; }

        public void Weapon()
        {
            Console.WriteLine("Тяжелое оружее ближнего радиуса действия");
        }

        public void Type()
        {
            Console.WriteLine("Тяжелый Mech");
        }

        public void Stratage()
        {
            Console.WriteLine("Хороший тактик");
        }
    }
}
