using Facade.Mech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var cool = new Cool();
            var shoot = new Shoot();
            var move = new Move();
            var fight = new Fight();
            var mechSystem = new MechSystem(cool, fight, move, shoot);
            
            //LightMech
            Console.WriteLine("LightMech");
            mechSystem.LightMech();
            Console.WriteLine();

            //HeavyMech
            Console.WriteLine("HeavyMech");
            mechSystem.HeavyMech();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
