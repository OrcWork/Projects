using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class User
    {
        private string name;
        private string surname;
        private string patronymic;
        private DateTime birthday;
        private int age;
        public static string nm;
        public static string sr;
        public static string pt;
        public static DateTime br;
        public static int ag;

        public User(string n, string s, string p, DateTime b, int a)
        {
            nm = n;
            sr = s;
            pt = p;
            br = b;
            ag = a;
        }

        public string Name
        {
            get { return name; }
            set { name = nm; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = sr; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = pt; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = br;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (ag > 0 & ag < 150)
                {
                    age = ag;
                }

            }
        }
    }
}
