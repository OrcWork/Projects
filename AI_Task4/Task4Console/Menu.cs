using AccessLibrary;
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
        AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
        AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
        public void MainMenu()
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
                    try
                    {
                        if (param == "File")
                        {

                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            Console.WriteLine(mpa.GetAll());
                        }
                        if (param == "Memory")
                        {
                            AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.GetAll());

                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(corm.GetAll(typeof(Person)));
                        }
                        if (param == "DataBase")
                        {
                            Console.WriteLine(anpa.GetAll());
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                    MainMenu();
                    break;

                // Поиск значения по имени
                case "2":
                    Console.WriteLine("Поиск значения по имени");
                    Console.WriteLine("Введите имя для поиска");
                    String nm2 = Console.ReadLine();
                    try
                    {
                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            Console.WriteLine(mpa.GetByName(nm2));
                        }
                        if (param == "Memory")
                        {
                            AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.GetByName(nm2));
                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(corm.GetByName(typeof(Person).GetField("name"), typeof(Person), nm2));
                        }
                        if (param == "DataBase")
                        {
                            Console.WriteLine(anpa.GetByName(nm2));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
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
                    try
                    {
                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            mpa.parseFile();
                            Console.WriteLine(mpa.Update(nm3, vl3));
                        }
                        if (param == "Memory")
                        {
                            AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.Update(nm3, vl3));
                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(corm.Update(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm3, vl3));
                        }
                        if (param == "DataBase")
                        {
                            Console.WriteLine(anpa.Update(nm3, vl3));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                    MainMenu();
                    break;

                // Удаление значения
                case "4":
                    Console.WriteLine("Удаление значения");
                    Console.WriteLine("Введите имя для удаления из списка");
                    String nm4 = Console.ReadLine();
                    try
                    {
                        if (param == "File")
                        {
                            AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                            mpa.parseFile();
                            Console.WriteLine(mpa.Delete(nm4));
                        }
                        if (param == "Memory")
                        {
                            AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                            Console.WriteLine(mpa.Delete(nm4));
                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(corm.Delete(typeof(Person).GetField("name"), typeof(Person), nm4));
                        }
                        if (param == "DataBase")
                        {
                            Console.WriteLine(anpa.Delete(nm4));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
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
                        Console.WriteLine(mpa.Add(nm5, vl5));
                    }
                    if (param == "Memory")
                    {
                        AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                        Console.WriteLine(mpa.Add(nm5, vl5));
                    }
                    if (param == "CustomORM")
                    {
                        Console.WriteLine(corm.Add(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm5, vl5));
                    }
                    if (param == "DataBase")
                    {
                        Console.WriteLine(anpa.Add(nm5, vl5));
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
    }
}
