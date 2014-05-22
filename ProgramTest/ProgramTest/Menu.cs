using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramTest
{
    class Menu
    {
        String i;


        public void MenuList(){
            Console.WriteLine(" ");
            Console.WriteLine("Выберите один из пунктов меню");
            Console.WriteLine("1 – загрузить из файла");
            Console.WriteLine("2 – добавить пару");
            Console.WriteLine("3 – удалить пару");
            Console.WriteLine("4 – найти пару");
            Console.WriteLine("0 - выход");
            i = Console.ReadLine();
            switch (i)
            {
                case "0":
                    Console.WriteLine("Вы выбрали выход");
 //                   Console.ReadKey();
                    break;
                case "1":
                    Console.WriteLine("Вы выбрали загрузить из файла");
                    //FileWork fw = new FileWork();
                   // fw.ReadFile();
                    AllFunctional al = new AllFunctional();
                    al.readFile();
 //                   Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Вы выбрали добавить пару");
                    break;
                case "3":
                    Console.WriteLine("Вы выбрали удалить пару");
                    break;
                case "4":
                    Console.WriteLine("Вы выбрали найти пару");
                    break;
                case "5":
                    Console.WriteLine("Вы выбрали парсить файл");
                    AllFunctional al5 = new AllFunctional();
                    al5.parseFile();
                    break;
                default:
                    Console.WriteLine("Выберите что-нибудь другое");
                    break;
            }
        }
    }
}
