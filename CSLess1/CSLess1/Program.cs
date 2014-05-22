using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CSLess1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("Data");

             if (di.Exists)
                 di.Delete(true);

            di.Create();

            StreamWriter sw = File.CreateText("C:\\Users\\Andrey_Isaev\\Documents\\Visual Studio 2010\\Projects\\CSLess1\\CSLess1\\bin\\Debug\\Data\\money.txt");

            Console.WriteLine("Привет!");

            int debetsum = 0;

            for (int i = 0; i < 10; i++)
            {
                string debet = "";
                Console.WriteLine("Введите доход: ");
                debet = Console.ReadLine();

                int debetint = 0;
                int.TryParse(debet, out debetint);
                debetsum += debetint;

            }
            sw.WriteLine("Ваш доход: " + debetsum);
            sw.WriteLine();

            int creditsum = 0;

            for (int i = 0; i < 10; i++)
            {
                string credit = "";
                Console.WriteLine("Введите расход: ");
                credit = Console.ReadLine();

                int creditint = 0;
                int.TryParse(credit, out creditint);
                creditsum += creditint;

            }
            sw.WriteLine("Ваш расход: " + creditsum);
            sw.WriteLine();



            int balance = debetsum - creditsum;
            sw.WriteLine("Ваш баланс: " + balance.ToString());
            sw.WriteLine();

            if (balance >= 0)
            {
                sw.WriteLine("Хорошо");
            }
            else
            {
                sw.WriteLine("Плохо");
            }

            sw.Close();

            Console.ReadKey();
        }
    }
}
