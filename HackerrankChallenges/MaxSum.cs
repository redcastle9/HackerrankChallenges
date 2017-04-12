using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class MaxSum
    {
        private int maxCurrent { get; set; }
        private int maxGlobal { get; set; }

        public MaxSum()
        {
            maxCurrent = 0;
            maxGlobal = maxCurrent;
        }

        public MaxSum(int[] A)
        {
            int maxCurrent = A[0];
            int maxGlobal = maxCurrent;

            for (int i = 1; i < A.Length - 1; i++)
            {
                maxCurrent = Max(A[i], maxCurrent + A[i]);
                if (maxCurrent > maxGlobal)
                    maxGlobal = maxCurrent;
            }

            Console.WriteLine(maxGlobal);
            Console.ReadLine();

        }

        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }

    }
}
