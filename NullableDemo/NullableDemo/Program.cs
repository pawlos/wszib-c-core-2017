using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = null;
            string b = a ?? "Default string";
            Console.WriteLine($"Hello World! {b}");
        }
    }
}
