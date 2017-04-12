using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class Recursion
    {
        public Recursion()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }

        private int Factorial(int n)
        {
            if (n > 1) {
                int f = Factorial(n - 1);
                return f * n;
            }
            return 1;
        }
    }

    
}
