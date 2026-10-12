using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    internal class Sum
    {
        public static void sums()
        {
            int a, b, c, result;
            Console.WriteLine("Enter a first number");
            String str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Enter a Second number");
            String str1 = Console.ReadLine();
            b = Convert.ToInt32(str1);

            Console.WriteLine("Enter a Three number");
            String str2 = Console.ReadLine();
            c = Convert.ToInt32(str2);

            result = Sum1(a, b, c);
            Console.WriteLine("Result of addiction of 3 number :" + result);
            Console.Read();
        }
        static int Sum1(int a, int b, int c)
        {
            int res;
            res = a + b + c;
            return res;
        }
    }
}