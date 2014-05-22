using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProgramTest
{
    class AllFunctional
    {
        String filename = "C:\\Users\\Andrey_Isaev\\documents\\visual studio 2010\\Projects\\ProgramTest\\ProgramTest\\TestFile.txt";
        //чтение файла
        public void readFile()
        {
            /* try
             {
                 using (StreamReader sr = new StreamReader(filename))
                 {

                     String line = sr.ReadLine();
                     while (line.Length != 0)
                     {
                         line = sr.ReadLine();
                         Console.WriteLine(line);
                     }

                     sr.Close();
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("The file could not be read:");
                 Console.WriteLine(e.Message);
             }*/

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Нажмите любую клавишу для перехода в Меню");
            Console.ReadKey();
            Menu m = new Menu();
            m.MenuList();
        }


        // парсинг файла
        public void parseFile()
        {
           /* try
            {
                using (StreamReader sr1 = new StreamReader("C:\\Users\\Andrey_Isaev\\documents\\visual studio 2010\\Projects\\ProgramTest\\ProgramTest\\TestFile.txt"))
                {
                    List<string> names = new List<string>();
                    List<string> value = new List<string>();
                    String line1 = sr1.ReadLine();
                    while (line1.Length != 0)
                    {
                        string[] ss = line1.Split('=');
                        //line1 = sr1.ReadLine();
                        names.Add(ss[0]);
                        value.Add(ss[1]);
                       // names.Add(ss[1]);
                        Console.WriteLine(line1);

                    }
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    sr1.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }*/
            try
            {
                String line;
                List<string> names = new List<string>();
                List<string> value = new List<string>();
                using (StreamReader sr = new StreamReader(filename)) 
            {
                while ((line = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                    //String line = sr.ReadLine();
                    string[] ss = line.Split('=');
                    names.Add(ss[0]);
                    names.Add(ss[1]);
                }
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                sr.Close();
            }
        } 
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }



            Console.ReadKey();
        }


        //запись в файл
        public void writeFile()
        {
        }


        //удаление из файла
        public void deleteFile()
        {
        }


        // поиск в файле
        public void searchFile()
        {
        }

    }
}
