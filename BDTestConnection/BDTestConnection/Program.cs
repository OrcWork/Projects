using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDTestConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            BDPersonAccesor dbpa = new BDPersonAccesor();
            //dbpa.Add();
            //dbpa.GetAll();
            //dbpa.GetByName();
            //dbpa.Delete();
            dbpa.Update();
        }
    }
}
