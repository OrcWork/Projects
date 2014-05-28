using Adapter.Adapter;
using Adapter.ClanMechs;
using Adapter.InnerSpheraMechs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IClanMech timberwolf = new TimberWolf();
            timberwolf.MechName = "Timber Wolf";
            MechWarriorInfo.MechInfo(timberwolf);

            IClanMech madcatmk2 = new MadCatMk2();
            madcatmk2.MechName = "Mad Cat Mk2";
            MechWarriorInfo.MechInfo(madcatmk2);

            IInnerSpheraMech highlander = new HighLander();
            highlander.MechName = "HighLander";
            MechAdapter adapter = new MechAdapter(highlander);
            MechWarriorInfo.MechInfo(adapter);

            IInnerSpheraMech victor = new Victor();
            victor.MechName = "Victor";
            MechAdapter adapter2 = new MechAdapter(victor);
            MechWarriorInfo.MechInfo(adapter2);

            Console.ReadLine();
        }
    }
}
