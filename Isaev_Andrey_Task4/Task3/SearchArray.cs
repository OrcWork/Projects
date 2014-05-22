using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task3
{
    static class SearchArray
    {
        static public string NegativeSearch(this Array array)
        {
            string s = "";
            foreach (int arr in array)
            {
                if (arr < 0)
                {
                    s = s + " " + arr.ToString();

                }
                
            }
            return s;
        }

        
    }
}
