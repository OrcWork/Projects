using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ProgramTest
{
    class FileWork
    {
        public void ReadFile() {
                               try
                   {
                       using (StreamReader sr = new StreamReader("C:\\Users\\Andrey_Isaev\\Documents\\Visual Studio 2010\\Projects\\ProgramTest\\ProgramTest\\TestFile.txt"))
                       {
//                           String line = sr.ReadToEnd();
//                           Console.WriteLine(line);
                           List<string> names = new List<string>();
                           List<string> value = new List<string>();
                           String line = sr.ReadLine();
//                           string[] ss = line.Split('=');
                           //ss[0] < — Первая часть
                           //ss[1] < — вторая часть 
//                           line = sr.ReadLine();
//                           Console.WriteLine(ss[0]);
//                           Console.WriteLine(ss[1]);
//                           Console.WriteLine(line);
                           while (line.Length != 0)
                           {
                               string[] ss = line.Split('=');
                               //ss[0] < — Первая часть
                               //ss[1] < — вторая часть 
                               line = sr.ReadLine();
                               names.Add(ss[0]);
                               value.Add(ss[1]);
//                               Console.WriteLine(ss[0]);
                           }
                           foreach (string name in names)
                           {
                               Console.WriteLine(name);
                           }
                           Console.WriteLine(names[0]);
                           sr.Close();
                       }
                   }
                   catch (Exception e)
                   {
                       Console.WriteLine("The file could not be read:");
                       Console.WriteLine(e.Message);
                   }
                               Console.ReadKey();
        }

        }
    }

