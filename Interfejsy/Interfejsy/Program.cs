using System;

namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman student = new Student("Paweł");
            student.Breath();
            Student student2 = new Student("Piotr");
            //student2.
            Console.WriteLine($"Witaj");
        }
    }
}
