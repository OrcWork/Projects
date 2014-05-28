using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadeSample.WashingMachine;

namespace FacadeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new WaterManagingSubsystem();
            var thermo = new Thermo();
            var engine = new Engine();
            var dryer = new Dryer();

            var washingMachine = new WashingMachine.WashingMachine(dryer, engine, thermo, water);

            // Cotton
            Console.WriteLine("Cotton");
            washingMachine.WashCotton();
            
            // Wool
            Console.WriteLine("Wool");
            washingMachine.WashWool();

            int temp = washingMachine.GetTemperature();
            // 1. принадлежат самому объекту
            // 2. методы объектов параметров
            // 3. созданы внутри метода
            // 4. поля текущего объекта

            Console.ReadLine();
        }
    }
}
