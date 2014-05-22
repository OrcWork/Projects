using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyORM
{
    class Program
    {
        static void Main(string[] args)
        {
            MyORMDBPersonAccesor mdbpa = new MyORMDBPersonAccesor();
            Menu m = new Menu();
            m.MainMenu();
            
            //dbpa.Add();
            //mdbpa.GetAll();
            //dbpa.GetByName();
            //dbpa.Delete();
            //mdbpa.Update();

        }
    }
}
