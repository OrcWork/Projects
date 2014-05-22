using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class SearchArray2
    {
        public string ElementSeacher(string str, Array array)
        {
            string s = "";
            if (str == "negative")
            {
                foreach (int arr in array)
                {
                    if (arr < 0)
                    {
                        s = s + " " + arr.ToString();

                    }

                }
            }
            if (str == "positive")
            {
                foreach (int arr in array)
                {
                    if (arr > 0)
                    {
                        s = s + " " + arr.ToString();

                    }

                }
            }

            return s;
        }
    }
}
