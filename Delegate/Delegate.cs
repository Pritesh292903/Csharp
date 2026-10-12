using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    delegate void Mydelegate(int x, int y); // declaration
    class Delegate
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main(string[] args)
        {
            Mydelegate obj = new Mydelegate(Add); // instatiation
            obj += sub;
            obj += mul;
            obj += div;

            obj(15, 5); //invocation
            Add(15, 5); // 2 type invocation
        }
    }
}