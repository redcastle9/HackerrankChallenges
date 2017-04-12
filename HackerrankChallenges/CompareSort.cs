using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class CompareSort
    {
        public List<Sorted> SortedValues { get; set; }

        public CompareSort(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                int currentValue = values[i];
                int position = i;
                while (position > 0 && values[position - 1] > currentValue)
                {
                    values[position] = values[position - 1];
                    position--;
                }
                values[position] = currentValue;
                for (int j = 0; j < values.Length; j++)
                    Console.Write(values[j] + " ");
                Console.WriteLine();
            }
            
        }

        public CompareSort(string[] values)
        {

        }
    }

    class Sorted
    {
        string[] _sval { get; set; }
        int[] _ival { get; set; }
    }
}
