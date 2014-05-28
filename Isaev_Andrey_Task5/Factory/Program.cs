using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Сфера:");
            MechFactory factorysph = new SphereMechFactory();
            factorysph.GetMech("LightMech");
            Console.WriteLine();
            factorysph.GetMech("MediumMech");
            Console.WriteLine();
            factorysph.GetMech("HeavyMech");
            Console.WriteLine();
            factorysph.GetMech("AssaultMech");
            Console.WriteLine();

            Console.WriteLine("Кланы:");
            MechFactory factorycln = new ClanMechFactory();
            factorycln.GetMech("LightMech");
            Console.WriteLine();
            factorycln.GetMech("MediumMech");
            Console.WriteLine();
            factorycln.GetMech("HeavyMech");
            Console.WriteLine();
            factorycln.GetMech("AssaultMech");

            Console.ReadKey();

        }
    }
}
