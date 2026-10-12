using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    internal class program_13
    {

        public static void Notes()
        {
            


        int amount;

            Console.WriteLine("Enter the amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                Console.WriteLine($"{note} {count}");
                amount = amount % note;

            }
            Console.ReadLine();
        }
    }
}