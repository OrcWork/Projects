using Adapter.ClanMechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MechWarriorInfo
    {
        public static void MechInfo(IClanMech clanMech)
        {
            Console.WriteLine("Краткое досье на роботов в группе:");
            Console.WriteLine(string.Format("Модель Mech'а: {0}", clanMech.MechName));
            Console.Write("Вооружение:");
            clanMech.Weapon();
            Console.Write("Тип Mech'а:");
            clanMech.Type();
            Console.Write("Краткое описание пилота:");
            clanMech.Honor();
            Console.WriteLine();
        }
    }
}
