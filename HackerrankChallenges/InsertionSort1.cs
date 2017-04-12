using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class InsertionSort1
    {
        public void insertionSort(int[] ar)
        {
            int size = ar.Length;
            string sortedArray = string.Empty;
            int element = ar[size - 1];
            bool done = false;
            for (int i = size - 2; i >= 0; i--)
            {
                if (ar[i] >= element)
                {
                    ar[i + 1] = ar[i];
                }
                else
                {
                    ar[i + 1] = element;
                    done = true;
                }
                for (int j = 0; j < size; j++)
                {
                    sortedArray += ar[j] + " ";
                }
                Console.WriteLine(sortedArray);
                sortedArray = string.Empty;
                if (done)
                    break;
            }
            if (!done)
            {
                ar[0] = element;
                for (int j = 0; j < size; j++)
                {
                    sortedArray += ar[j] + " ";
                }
                Console.WriteLine(sortedArray);
            }
        }
    }
}