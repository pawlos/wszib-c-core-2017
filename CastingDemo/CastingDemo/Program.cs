using System;
using Interfejsy;

namespace CastingDemo
{
    class Program
    {
        public static Human Create(bool fullTime, string firstName)
        {
            if (fullTime)
            {
                return new FullTimeStudent(firstName);
            }
            else
            {
                return new Student(firstName);
            }            
        }
        static void Main(string[] args)
        {
            Human student = Create(false, "❤");
            string human = student.ToString();
            //student.
            Student student2 = student as Student;
            student2.
            if (student2 != null)
            {
                Console.WriteLine(student2);
            }
        }
    }
}
