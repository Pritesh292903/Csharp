using System;

namespace Csharp
{
    internal class program_9
    {
        public static void repeat()
        {
            int[] arr = { 1, 2, 3, 4, 5, 2, 3 };

            Console.WriteLine("Numbers occurring once:");

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}