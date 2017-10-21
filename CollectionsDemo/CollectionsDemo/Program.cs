using System;
using System.Collections;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack al = new Stack();
            al.Push("Hello");
            al.Push("World");
            //al.Push(2017);
            //al.Push(new object());
            string input;
            while((input = Console.ReadLine())!="quit")
            {
                al.Push(input);
            }
            Console.WriteLine("Wypisuję kolekcję: ");            
            foreach(string el in al)
            {
                Console.Write($"{el}, ");
            }
            Console.ReadLine();
        }
    }
}
