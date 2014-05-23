using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class BisnessLogic
    {
        public void GetAll()
        {
          /*  var ioc = new UnityContainer();
           // Application.Run(uc.Resolve<MyWindow>());
            //AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
            //Console.WriteLine(mpa.GetByName(nm));
            var mpa = ioc.Resolve<MemoryPersonAccessor>();
            Console.WriteLine(mpa.GetByName(nm));
            //Console.WriteLine();*/
            MemoryPersonAccessor mpa = new MemoryPersonAccessor();
            mpa.GetAll();
        }
    }
}
