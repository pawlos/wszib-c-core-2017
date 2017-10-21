using System;

namespace StructDemo
{
    class Program
    {
        static void PrintStudent(ref Student s, out bool wasPrinted)
        {
            Console.WriteLine($"Nr studenta: {s.No}");
            s.No = 13;
            wasPrinted = true;
        }

        static void Main(string[] args)
        {
            Student s = new Student(12);
            bool wasPrinted;            
            PrintStudent(ref s, out wasPrinted);
            PrintStudent(ref s, out wasPrinted);
        }
    }
}
