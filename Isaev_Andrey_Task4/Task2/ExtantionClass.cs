using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    static class ExtantionClass
    {
        
        static public string CheckValue(this String str)
        {
            bool s = true;
            char[] chr = str.ToCharArray();
            //Определяем состоит ли вся строка которую передаем из цифр
            for (int i = 0; i < chr.Length; i++)
            {
                switch (chr[i])
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '0':
                        break;

                    default:
                        s = false;
                        break;
                }
            }
            if (s)
            {
                return "Строка является целым положительным числом";
            }
            else
            {
                return "Строка не является целым положительным числом";
            }
        }
    }
}
