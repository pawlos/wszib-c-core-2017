using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Student> dict = new Dictionary<string, Student>();
            ////List<T>                      
            //dict.Add("12121212", new Student("Paweł"));
            //dict["12121212"] = new Student("Piotr");
            //Student student;
            //if (dict.TryGetValue("12121212", out student))
            //{ 
            //    Console.WriteLine(student.FirstName);
            //}
            //Class<int> c = new Class<int>(12);
            Student s = new Student(12, "Paweł");
            //dict.Add("12121212", s);
            //Student s1 = dict["12121212"];
            //Console.WriteLine(s1.FirstName, s1.Id);
            Class<int> cs = new Class<int>(12);
            Dictionary<Class<Class<int>>, Class<string>> dict = new Dictionary<Class<Class<int>>, Class<string>>();
            List<Class<int>> list = new List<Class<int>>();
        }
    }
}
