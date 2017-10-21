using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class Class<T>                      
    {
        public string Name { get; }

        public T Value { get; } 
        public Class(T value)
        {
            Value = value;
            Console.WriteLine(typeof(T).FullName);
        }

        //public T Create()
        //{
        //    return new T();
        //}
    }
}
