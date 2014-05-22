using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class FilePersonAccessor : IPersonAccessor
    {
        String filename = "TextFile121.txt";
       // String filename = @"D:\C#\Projects\AI_Task4\Task4Web\TextFile1.txt";
        List<string> name = new List<string>();
        List<string> value = new List<string>();
        Exception notFoundExcaption = new Exception("Имя не найдено");
        Exception readFileExcaption = new Exception("Ошибка чтения файла, проверьте указанный путь к файлу");
        Exception parseFileExcaption = new Exception("Невозможно распарсить файл");
        Exception rewriteFileExcaption = new Exception("Невозможно записать данные файл");
        string str = "";

        // Вывод всех значений в файле
        public string GetAll()
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                str = sr.ReadToEnd();
                sr.Close();

            }
            catch
            {
                //str = "Ошибка чтения файла";
                throw readFileExcaption;
            }
            return str;
        }

        //Поиск значения по имени
        public string GetByName(string nm)
        {
            String line;
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] ss = line.Split('=');

                    if (ss[0] == nm)
                    {
                        str = line;
                        break;
                    }
                }
                if (!name.Contains(nm) & str == "") throw notFoundExcaption;
  /*              {
                    str = "Имя не найдено";
                }*/
                sr.Close();
                return str;
            }
        }


        //Перезапись значения в файле
        public string Update(string nm, string vl)
        {
            if (!name.Contains(nm)) throw notFoundExcaption;
/*            {
                str = "Имя не найдено";
            }*/
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    value[i] = vl;
                    str = "Значение перезаписано";
                }
            }

            Rewrite();
            return str;
        }

        //Удаление Значения из файла
        public string Delete(string nm)
        {
            if (!name.Contains(nm)) throw notFoundExcaption;
 /*           {
                str = "Имя не найдено";
            }*/
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    name.RemoveAt(i);
                    value.RemoveAt(i);
                    str = "Значение удалено";
                }
            }
            
            Rewrite();
            return str;
        }

        // Метод который парсит файл и записывает его в листы
        public void parseFile()
        {
            try
            {
                String line;
                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] ss = line.Split('=');
                        name.Add(ss[0]);
                        value.Add(ss[1]);
                    }
                    sr.Close();
                }
            }
            catch
            {
               // Console.WriteLine("The process failed: {0}", e.ToString());
                throw parseFileExcaption;
            }
        }

        //Метод перезаписи файла
        public void Rewrite()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    for (int i = 0; i < name.Count; i++)
                    {
                        if (i != name.Count - 1)
                        {
                            sw.Write("{0}={1}\n", name[i], value[i]);
                        }
                        else
                        {
                            sw.Write("{0}={1}", name[i], value[i]);
                        }
                    }
                    sw.Close();
                }
            }
            catch
            {
              /*  Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);*/
                throw rewriteFileExcaption;
            }
        }

        //Добавление нового значения в файл
        public string Add(string nm, string vl)
        {
            name.Add(nm);
            value.Add(vl);
            Rewrite();
            str = "Новое значение добавлено";
            return str;
        }

    }
}
