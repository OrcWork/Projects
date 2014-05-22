using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
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

                System.Console.Write("Введите стаж: ");
                int experience = int.Parse(System.Console.ReadLine()); ;
                System.Console.Write("Введите должность: ");
                string post = Console.ReadLine();;

                Employee empl = new Employee(n, s, p, b, a, experience, post);
                empl.Name = null;
                empl.Surname = null;
                empl.Patronymic = null;
                empl.Birthday = new DateTime();
                empl.Age = 0;
                empl.Experience = 0;
                empl.Post = null;


                DateTime brth = empl.Birthday;
                DateTime b1 = brth.Date;
                DateTime thisDay = DateTime.Today;
                int tsd = thisDay.Year;
                int brthday = brth.Year;
                int age1 = tsd - brthday;


                if (age1 == empl.Age & experience > 0 & experience < age1)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Ваши данные");
                    System.Console.WriteLine("Имя: " + empl.Name);
                    System.Console.WriteLine("Фамилия: " + empl.Surname);
                    System.Console.WriteLine("Отчество: " + empl.Patronymic);
                    System.Console.WriteLine("Дата рождения: " + b1.ToString("d"));
                    System.Console.WriteLine("Возраст: " + empl.Age);
                    System.Console.WriteLine("Трудовой стаж: " + empl.Experience);
                    System.Console.WriteLine("Должность: " + empl.Post);
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
