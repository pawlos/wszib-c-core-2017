using System;

namespace DelegatesDemo
{
    class Program
    {
        public static int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
        public static int Sub(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public static int Mul(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public static int Div(int arg1, int arg2)
        {
            return arg1 / arg2;
        }
        public delegate int Operation(int arg1, int arg2);

        public static void ExecuteOperation(int arg1, int arg2, Operation op)
        {
            var result = op(arg1, arg2);
            op.Method
            //result zmieniamy jak chcemy
            result *= 2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Operation operacja = null;
            string op = Console.ReadLine();
            if (op == "+")
                operacja = Add;
            else if (op == "-")
                operacja = Sub;
            else if (op == "*")
                operacja = Mul;
            else if (op == "/")
                operacja = Div;

            ///
            ExecuteOperation(1, 2, operacja)            
        }
    }
}