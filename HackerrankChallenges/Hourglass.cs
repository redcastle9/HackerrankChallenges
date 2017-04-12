using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class Hourglass
    {
        public Hourglass(int[][] A)
        {
            int maxSum = -9*7;
            int constraint = 6;

            int rowLength = A.Length > constraint ? constraint : A.Length;
            int colLength = A[0].Length > constraint ? constraint : A[0].Length;
            for (int row = 0; row < rowLength - 2; row++)
            {
                for (int col = 0;col < colLength - 2;col++)
                {
                    Console.WriteLine("");
                    Console.WriteLine(A[row][col] + " " + A[row][col + 1] + " " + A[row][col + 2]);
                    Console.WriteLine("  " + A[row + 1][col + 1]);
                    Console.WriteLine(A[row + 2][col] + " " + A[row + 2][col + 1] + " " + A[row + 2][col + 2]);

                    int sum = A[row    ][col] + A[row    ][col + 1] + A[row    ][col + 2]
                                              + A[row + 1][col + 1]
                            + A[row + 2][col] + A[row + 2][col + 1] + A[row + 2][col + 2];

                    Console.WriteLine("SUM: " + sum);
                    if (maxSum < sum)
                        maxSum = sum;
                }
            }
            Console.WriteLine(maxSum);

            Console.ReadLine();
        }
    }
}
