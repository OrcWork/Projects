using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Task2
{
    class ReadFile
    {
        public void FileRead()
        {
            String filename = "File.txt";
            try
            {
                String line;
                ArrayList words = new ArrayList();
                ArrayList words2 = new ArrayList();
                using (StreamReader sr = new StreamReader(filename))
                {
                    //Разбиваем весь файл на слова и сохраняем их в список
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (string word in line.Split((new Char[] { ' ', ',', '.', ':', '\t' })))
                        {
                            if (word != "")
                                words.Add(word.ToLower());
                        }
                    }
                    // начинаем сравнивать каждое слово со спсиском
                    // подсчитываем кол-во совпадений и записываем это слово в другой список words2
                    // если в тексте встретится такое же слово, тооно не будет считаться по второму разу
                    for (int i = 0; i < words.Count; i++)
                    {
                        int c = 0;

                        for (int j = 0; j < words.Count; j++)
                        {
                            if (words[j].ToString() == words[i].ToString())
                            {
                                c++;
                            }
                        }
                        string s = words[i].ToString() + " : " + c;
                        if (!words2.Contains(s))
                        {
                            words2.Add(s);
                        }
                    }
                    foreach (string word in words2)
                    {
                        Console.WriteLine(word);
                    }
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
