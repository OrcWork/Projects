using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Path: ");
            string filePath = Console.ReadLine();

            ContactManager cm = new ContactManager(filePath);

            Console.WriteLine("Entries: ");

            foreach (ContactEntry ce in cm.Entries)
            {
                Console.WriteLine(ce.ToString());
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
