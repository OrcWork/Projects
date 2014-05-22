using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Employee : User
    {
        private int experience;
        private string post;
        public static string pst;
        public static int exp;

        public Employee(string n, string s, string p, DateTime b, int a, int experience, string post) : base (n, s, p, b, a)
        {
            exp = experience;
            pst = post;
        }


        public int Experience
        {
            get { return experience; }
            set { experience = exp; }
        }

        public string Post
        {
            get { return post; }
            set { post = pst; }
        }
    }
}
