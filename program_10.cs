using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    internal class program_10
    {
        public static void matrix()

        {
            static int MatSearch(int[,] mat,int n, int m, int x)
            {

                int row = 0;
                int col = m - 1;

                while (row<n && col >= 0)
                {

                    if (mat[row, col] == x)
                        return 1;

                    else if (mat[row, col] > x)
                        col--;
                    else
                        row++;
                }

                return 0;
            }

            static void Main(string[] args)

            {
                int[,] mat = { { 10, 20, 30, 40 },
                           { 15, 25, 35, 45 },
                           { 27, 29, 37, 48 },
                           { 32, 33, 39, 50 } };

                int result = MatSearch(mat, 4,4, 29);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}