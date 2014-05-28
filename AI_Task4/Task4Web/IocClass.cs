using AccessLibrary;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Task4Web
{
    public class IocClass
    {
                // IOC
        public void Ioc()
        {
            var container = new UnityContainer();
            //container.RegisterType<IMenu, Menu>();
            container.RegisterType<IBisnessLogic, BisnessLogic>();
            String param = ConfigurationManager.AppSettings["Source"];
            if (param == "Memory")
            {
                container.RegisterType<IPersonAccessor, MemoryPersonAccessor>();
            }
            if (param == "File")
            {
                container.RegisterType<IPersonAccessor, FilePersonAccessor>();
            }
            if (param == "DataBase")
            {
                container.RegisterType<IPersonAccessor, ADONETPersonAccessor>();
            }
            if (param == "CustomORM")
            {
                container.RegisterType<IPersonAccessor, DBPersonAccessor>();
            }
            //container.Resolve<IMenu>().MainMenu();
            //container.Resolve<WebForm1>().Page_Load();
        }
    }
    }
