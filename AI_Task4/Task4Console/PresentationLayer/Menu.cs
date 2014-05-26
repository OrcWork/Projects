using AccessLibrary;
using AccessLibrary.BisnessAccessLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4Console.PresentationLayer;

namespace Task4Console
{
    class Menu :IMenu
    {
        private readonly IBisnessLogic _bisnessLogic;
        String param = ConfigurationManager.AppSettings["Source"];

        public Menu(IBisnessLogic bisnessLogic)
        {
            _bisnessLogic = bisnessLogic;
        }


        public void MainMenu()
        {
            if (param == "Memory")
            {
                Console.WriteLine("Работа с мемори");
            }
            if (param == "File")
            {
                Console.WriteLine("Работа с файлом");
            }
            if (param == "DataBase")
            {
                Console.WriteLine("Работа с базой данных");
            }
            if (param == "CustomORM")
            {
                Console.WriteLine("Работа с базой данных при помощи кастомного ORM");
            }

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

                        if (param == "Memory" || param == "File" || param == "DataBase")
                        {
                            Console.WriteLine(_bisnessLogic.GetAll());
                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(_bisnessLogic.GetAllORM(typeof(Person)));
                        }
                        Console.ReadKey();
                        MainMenu();
                        break;

                    // Поиск значения по имени
                    case "2":
                        Console.WriteLine("Поиск значения по имени");
                        Console.WriteLine("Введите имя для поиска");
                        String nm2 = Console.ReadLine();
                        if (param == "Memory" || param == "File" || param == "DataBase")
                        {
                            Console.WriteLine(_bisnessLogic.GetByName(nm2));
                        }
                        if (param == "CustomORM")
                        {
                            Console.WriteLine(_bisnessLogic.GetByNameORM(typeof(Person).GetField("name"), typeof(Person), nm2));
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

                        if (param == "Memory" || param == "File" || param == "DataBase")
                        {
                            _bisnessLogic.Update(nm3, vl3);
                        }
                        if (param == "CustomORM")
                        {
                            _bisnessLogic.UpdateORM(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm3, vl3);
                        }

                        Console.WriteLine("Значение перезаписано");
                        Console.ReadKey();
                        MainMenu();
                        break;

                    // Удаление значения
                    case "4":
                        Console.WriteLine("Удаление значения");
                        Console.WriteLine("Введите имя для удаления из списка");
                        String nm4 = Console.ReadLine();

                        if (param == "Memory" || param == "File" || param == "DataBase")
                        {
                            _bisnessLogic.Delete(nm4);
                        }
                        if (param == "CustomORM")
                        {
                            _bisnessLogic.DeleteORM(typeof(Person).GetField("name"), typeof(Person), nm4);
                        }
                        Console.WriteLine("Значение удалено");
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

                        if (param == "Memory" || param == "File" || param == "DataBase")
                        {
                            _bisnessLogic.Add(nm5, vl5);
                        }
                        if (param == "CustomORM")
                        {
                            _bisnessLogic.AddORM(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm5, vl5);
                        }

                        Console.WriteLine("Новое значение добавлено");
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
