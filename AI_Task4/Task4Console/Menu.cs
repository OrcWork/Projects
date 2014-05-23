using AccessLibrary;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    class Menu
    {
        String param = ConfigurationManager.AppSettings["Source"];

        public void MainMenu()
        {
            //----------------------
            //IOC
       /*     IUnityContainer container = new UnityContainer();
            container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.MemoryPersonAccessor>();
            //var memory = container.Resolve<AccessLibrary.IPersonAccessor>();
            container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.FilePersonAccessor>();
            var memory = container.Resolve<AccessLibrary.IPersonAccessor>();
            //var file = container.Resolve<AccessLibrary.IPersonAccessor>();*/
            IUnityContainer container = new UnityContainer();
            if (param == "Memory")
            {
                //container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.MemoryPersonAccessor>();
                container.RegisterType<AccessLibrary.BisnessLogic>().RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.MemoryPersonAccessor>();
            }
            if (param == "File")
            {
                container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.FilePersonAccessor>();
            }
            if (param == "DataBase")
            {
                container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.ADONETPersonAccessor>();
            }
            var allaccessors = container.Resolve<AccessLibrary.IPersonAccessor>();
          /*  if (param == "CustomORM")
            {
                container.RegisterType<AccessLibrary.IPersonAccessor, AccessLibrary.DBPersonAccessor>();
            }*/

            //-------------------------


            try
            {
                Console.WriteLine("1 - Отобразить все значения");
                Console.WriteLine("2 - Поиск значения по имени");
                Console.WriteLine("3 - Перезапись значения");
                Console.WriteLine("4 - Удаление значения");
                Console.WriteLine("5 - Добавление нового значения");
                Console.WriteLine("0 - Выход");

                String n = Console.ReadLine();
                switch (n)
                {
                    case "0":
                        Console.WriteLine("Вы выбрали выход");
                        break;

                    // Отобразить все значения
                    case "1":
                        Console.WriteLine("Отобразить все значения");
                        Console.WriteLine("Ввывод всех имен и значений");
                        if (param == "File")
                        {

                          /*  AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            Console.WriteLine(mpa.GetAll());*/
                            Console.WriteLine(allaccessors.GetAll());
                        }
                        if (param == "Memory")
                        {
                            /* AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                             Console.WriteLine(mpa.GetAll());*/
                            Console.WriteLine(allaccessors.GetAll());

                        }
                        if (param == "CustomORM")
                        {
                            AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
                            Console.WriteLine(corm.GetAll(typeof(Person)));
                        }
                        if (param == "DataBase")
                        {
                           // AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
                            Console.WriteLine(allaccessors.GetAll());
                        }
                        Console.ReadKey();
                        MainMenu();
                        break;

                    // Поиск значения по имени
                    case "2":
                        Console.WriteLine("Поиск значения по имени");
                        Console.WriteLine("Введите имя для поиска");
                        String nm2 = Console.ReadLine();
                        if (param == "File")
                        {
                            /*AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            Console.WriteLine(mpa.GetByName(nm2));*/
                            Console.WriteLine(allaccessors.GetByName(nm2));
                        }
                        if (param == "Memory")
                        {
                            /*  AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                              Console.WriteLine(mpa.GetByName(nm2));*/
                            /*    AccessLibrary.BisnessLogic bl = new AccessLibrary.BisnessLogic();
                                bl.GetAll(nm2);*/
                            Console.WriteLine(allaccessors.GetByName(nm2));
                        }
                        if (param == "CustomORM")
                        {
                            AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
                            Console.WriteLine(corm.GetByName(typeof(Person).GetField("name"), typeof(Person), nm2));
                        }
                        if (param == "DataBase")
                        {
                           // AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
                            Console.WriteLine(allaccessors.GetByName(nm2));
                        }
                        Console.ReadKey();
                        MainMenu();
                        break;

                    // Перезапись значения
                    case "3":
                        Console.WriteLine("Перезапись значения");
                        Console.WriteLine("Введите имя для поиска");
                        String nm3 = Console.ReadLine();
                        Console.WriteLine("Введите новое значение");
                        String vl3 = Console.ReadLine();

                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            mpa.parseFile();
                            Console.WriteLine(mpa.Update(nm3, vl3));
                        }
                        if (param == "Memory")
                        {
                           /* AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.Update(nm3, vl3));*/
                            Console.WriteLine(allaccessors.Update(nm3, vl3));
                        }
                        if (param == "CustomORM")
                        {
                            AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
                            Console.WriteLine(corm.Update(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm3, vl3));
                        }
                        if (param == "DataBase")
                        {
                           // AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
                            Console.WriteLine(allaccessors.Update(nm3, vl3));
                        }

                        Console.ReadKey();
                        MainMenu();
                        break;

                    // Удаление значения
                    case "4":
                        Console.WriteLine("Удаление значения");
                        Console.WriteLine("Введите имя для удаления из списка");
                        String nm4 = Console.ReadLine();
                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            mpa.parseFile();
                            Console.WriteLine(allaccessors.Delete(nm4));
                        }
                        if (param == "Memory")
                        {
                          /*  AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.Delete(nm4));*/
                            Console.WriteLine(allaccessors.Delete(nm4));
                        }
                        if (param == "CustomORM")
                        {
                            AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
                            Console.WriteLine(corm.Delete(typeof(Person).GetField("name"), typeof(Person), nm4));
                        }
                        if (param == "DataBase")
                        {
                            //AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
                            Console.WriteLine(allaccessors.Delete(nm4));
                        }

                        Console.ReadKey();
                        MainMenu();
                        break;

                    //Добаление значения
                    case "5":
                        Console.WriteLine("Добавление нового значения");
                        Console.WriteLine("Введите имя для добавления в список");
                        String nm5 = Console.ReadLine();
                        Console.WriteLine("Введите значение для добавления в список");
                        String vl5 = Console.ReadLine();
                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            mpa.parseFile();
                            Console.WriteLine(allaccessors.Add(nm5, vl5));
                        }
                        if (param == "Memory")
                        {
                           /* AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.Add(nm5, vl5));*/
                            Console.WriteLine(allaccessors.Add(nm5, vl5));
                        }
                        if (param == "CustomORM")
                        {
                            AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
                            Console.WriteLine(corm.Add(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm5, vl5));
                        }
                        if (param == "DataBase")
                        {
                            //AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
                            Console.WriteLine(allaccessors.Add(nm5, vl5));
                        }
                        Console.ReadKey();
                        MainMenu();
                        break;


                    default:
                        Console.WriteLine("Выберите что-нибудь другое");
                        MainMenu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(" ");
                MainMenu();

            }

        }
    }
}
