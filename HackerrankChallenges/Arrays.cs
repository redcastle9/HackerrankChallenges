using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class Arrays
    {
        public int n { get; set; }
        public string[] arr_temp { get; set; }
        public int[] arr { get; set; }

        public Arrays(int N, string Arr_Temp)
        {
            n = N;
            arr_temp = Arr_Temp.Split(' ');
            arr = Array.ConvertAll(arr_temp, Int32.Parse);
        }
    }
}
