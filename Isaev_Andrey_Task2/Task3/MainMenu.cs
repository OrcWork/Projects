using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class MainMenu
    {
        DynamicArray da = new DynamicArray();
        NumClass nc = new NumClass();
        public void Menu()
        {
            // Главное меню
            Console.WriteLine("1 - Создать массив емкостью 8 элементов");
            Console.WriteLine("2 - Создать массив заданной емкости");
            Console.WriteLine("3 - Создать массив для коллекции реализующий интерфейс IEnumerable");
            Console.WriteLine("4 - Добавить элемент в массив (если невозможно добавить элемент, то емкость массива увеличивается в 2 раза)");
            Console.WriteLine("5 - Добавить в конец массива коллекцию реализующий интерфейс IEnumerable");
            Console.WriteLine("6 - Удалить из коллекции указанный элемент");
            Console.WriteLine("7 - Вставить элемент в массив");
            Console.WriteLine("8 - Вывести длинну массива");
            Console.WriteLine("9 - Вывести реальную длинну массива");
            Console.WriteLine("10 - Отобразить массив");
            Console.WriteLine("0 - Выход");
            Console.WriteLine(" ");
            string m = Console.ReadLine();
            switch (m)
            {
                case "1":
                    DynamicArray da1 = new DynamicArray();
                    Console.WriteLine("Массив создан");
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "2":
                    Console.WriteLine("Задайте емкость массива");
                    string mas = Console.ReadLine();
                    try
                    {
                        DynamicArray da2 = new DynamicArray(Convert.ToInt32(mas));
                        
                    }
                    catch
                    {
                        da.ConsoleReadEcxeption();
                    }
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "3":
                    nc.Method();
                    Console.WriteLine("Создан массив для коллекции реализующий интерфейс IEnumerable");
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "4":
                    Console.WriteLine("Введите элемент для добавления");
                    string elm = Console.ReadLine();
                    try
                    {
                        da.Add(Convert.ToInt32(elm));
                        Console.WriteLine("Элемент добавлен");
                    }
                    catch
                    {
                        da.ConsoleReadEcxeption();
                    }
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "5":
                    nc.Method2();
                    Console.WriteLine("В конец массива добавлена коллекции реализующий интерфейс IEnumerable");
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "6":
                    Console.WriteLine("Введите номер элемента для удаления");
                    string elnum6 = Console.ReadLine();
                    try
                    {
                        int value6 = Convert.ToInt32(elnum6);
                        Console.WriteLine(da.Remove(value6));
                        bool flag6 = da.Remove(value6);
                        if (flag6 == true)
                        {
                            Console.WriteLine("Элемент успешно удален из массива " + flag6);
                        }
                        else
                        {
                            Console.WriteLine("Произошла ошибка при удалении элемента из массива" + flag6);
                            da.ArgumentOutOfRangeException();
                        }
                    }
                    catch
                    {
                        da.ConsoleReadEcxeption();
                    }

                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "7":
                    Console.WriteLine("Введите номер элемента для добавления в массив");
                    string elnum7 = Console.ReadLine();
                    Console.WriteLine("Введите элемент для добавления в массив");
                    string elnum71 = Console.ReadLine();
                    try
                    {
                        int value7 = Convert.ToInt32(elnum7);
                        int value71 = Convert.ToInt32(elnum71);
                        bool flag7 = da.Insert(value7, value71);
                        if (flag7 == true)
                        {
                            Console.WriteLine("Элемент успешно вставлен в массив " + flag7);
                        }
                        else
                        {
                            Console.WriteLine("Произошла ошибка при вставке элемента в массив " + flag7);
                            da.ArgumentOutOfRangeException();
                        }
                    }
                    catch
                    {
                        da.ConsoleReadEcxeption();
                    }
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "8":
                    Console.WriteLine("Длинна массива: " + da.Length);
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "9":
                    Console.WriteLine("Реальная длинна массива: " + da.Capacity);
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "10":
                    Console.WriteLine("Массив:");
                    da.Print();
                    Console.WriteLine(" ");
                    Menu();
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("Выберите что-нибудь другое");
                    Console.WriteLine("");
                    Menu();
                    break;
            }
        }
    }
}
