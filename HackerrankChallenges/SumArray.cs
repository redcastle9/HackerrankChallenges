using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class SumArray
    {
        private int n;
        private int[] arr;

        public SumArray()
        {
            n = 0;
            arr = new int[n];
        }

        public SumArray(int N, int[] ARR)
        {
            n = N;
            arr = new int[n];
            arr = ARR;

        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = arr[i];
                sum += num;
            }
            return sum;
        }
    }
}
