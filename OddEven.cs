using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public class OddEven
    {
        public static void evenodd()
        {
            int number;
            Console.Write("Enter a number :");

            number = Convert.ToInt32(Console.ReadLine());

            // number str = Console.ReadLIne();
            // number = Convert.ToInt32(str);

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}