using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Введите имя: ");
                string n = Console.ReadLine(); ;

                Console.Write("Введите Фамилию: ");
                string s = Console.ReadLine(); ;

                System.Console.Write("Введите отчество: ");
                string p = Console.ReadLine();

                System.Console.Write("Введите дату рождения в формате дд/мм/гггг: ");
                DateTime b = DateTime.Parse(System.Console.ReadLine());

                System.Console.Write("Введите возраст: ");
                int a = int.Parse(System.Console.ReadLine());

                User usr = new User(n, s, p, b, a);
                usr.Name = null;
                usr.Surname = "";
                usr.Patronymic = "";
                usr.Birthday = new DateTime();
                usr.Age = 0;

                DateTime brth = usr.Birthday;
                DateTime b1 = brth.Date;
                DateTime thisDay = DateTime.Today;
                int tsd = thisDay.Year;
                int brthday = brth.Year;
                int age1 = tsd - brthday;

                if (age1 == usr.Age)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Ваши данные");
                    System.Console.WriteLine("Имя: " + usr.Name);
                    System.Console.WriteLine("Фамилия: " + usr.Surname);
                    System.Console.WriteLine("Отчество: " + usr.Patronymic);
                    System.Console.WriteLine("Дата рождения: " + b1.ToString("d"));
                    System.Console.WriteLine("Возраст: " + usr.Age);
                }
                else
                {
                    System.Console.WriteLine("Вы указали неверный возраст");
                }
                
            }
            catch
            {
                System.Console.WriteLine("Введены некорректные данные");
            }
            Console.ReadKey();
        }
    }
}
