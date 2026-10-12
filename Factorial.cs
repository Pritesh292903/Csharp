using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    internal class Factorial
    {

        public static void fact()
        {

            int number;
            int fact = 1;
            Console.Write("Enter a number :");

            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)

            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + fact);
            Console.ReadLine();
        }

    }
}
