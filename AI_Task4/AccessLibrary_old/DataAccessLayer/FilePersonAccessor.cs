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
        String filename = "TextFile1.txt";
        //String filename = @"D:\C#\Projects\AI_Task4\Task4Web\TextFile1.txt";
        List<string> name = new List<string>();
        List<string> value = new List<string>();
        Exception notFoundExcaption = new Exception("Имя не найдено");
        Exception readFileExcaption = new Exception("Ошибка чтения файла, проверьте указанный путь к файлу");
        Exception parseFileExcaption = new Exception("Невозможно распарсить файл");
        Exception rewriteFileExcaption = new Exception("Невозможно записать данные файл");

        // Вывод всех значений в файле
        public string GetAll()
        {
            string str = "";
            try
            {
                StreamReader sr = new StreamReader(filename);
                str = sr.ReadToEnd();
                sr.Close();

            }
            catch
            {
                throw readFileExcaption;
            }
            return str;
        }

        //Поиск значения по имени
        public string GetByName(string nm)
        {
            string str = "";
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
                sr.Close();
                return str;
            }
        }


        //Перезапись значения в файле
        public void Update(string nm, string vl)
        {
            ParseFile();
            if (!name.Contains(nm)) throw notFoundExcaption;
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    value[i] = vl;
                }
            }

            Rewrite();
        }

        //Удаление Значения из файла
        public void Delete(string nm)
        {
            ParseFile();
            if (!name.Contains(nm)) throw notFoundExcaption;
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].ToString() == nm)
                {
                    name.RemoveAt(i);
                    value.RemoveAt(i);
                }
            }
            
            Rewrite();
        }

        // Метод который парсит файл и записывает его в листы
        public void ParseFile()
        {
            name = new List<string>();
            value = new List<string>();
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
        public void Add(string nm, string vl)
        {
            ParseFile();
            name.Add(nm);
            value.Add(vl);
            Rewrite();
        }



        public string GetAllORM(Type t)
        {
            throw new NotImplementedException();
        }


        public string GetByNameORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void UpdateORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }

        public void DeleteORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void AddORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }
    }
}
