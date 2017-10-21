using System;
using System.Collections.Generic;

namespace AnonimoweTypyDemo
{
    class Program
    {
        public static string Execute(string s)
        {
            Console.WriteLine(s);
            return s.ToUpper();
        }
        static void Main(string[] args)
        {
            var anonim = new { FirstName = "Gall", LastName = "Anonim", Age = 82M, Address = new { Street = "Bracka", City = "Kraków" } };
            var anonim2 = new { FirstName = "Gall", Age = 82M, LastName = "Anonim" };

            Console.WriteLine(anonim.Equals(anonim2));
            //Console.WriteLine(anonim.LastName);
        }
    }
}
