using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class Binary
    {
        public Binary()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(N, 2);
            int total = 0;
            int sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {

                if (binary[i] == '0')
                {
                    sum = 0;
                }
                else
                {
                    sum++;
                }

                if (sum > total)
                    total = sum;
            }
            Console.WriteLine(binary);
            Console.WriteLine(total);
        }
    }
}
