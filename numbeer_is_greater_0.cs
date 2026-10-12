using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    internal class numbeer_is_greater_0
    {

        public static void Zero()
        { 
        
            int number;
            Console.WriteLine("Enter A number");

            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)

            {

                Console.WriteLine("number is Zero");
            }
            else if(number > 0)
            {
                Console.WriteLine("number is Positive");
            }
            else
            {
                Console.WriteLine("number is Negative");
            }

        }

    }
}
