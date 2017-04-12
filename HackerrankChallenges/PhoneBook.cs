using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class PhoneBook
    {
        public PhoneBook()
        {

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');

                phoneBook.Add(arr[0], arr[1]);
            }

            string[] arrQueries;
            arrQueries = new string[N];
            for (int j = 0; j < N; j++)
            {
                arrQueries[j] = Console.ReadLine();
            }

            for (int k = 0; k < N; k++)
            {
                string key = arrQueries[k];

                if (phoneBook.ContainsKey(key))
                {
                    //print out key=value
                    Console.WriteLine("{0}={1}", key, phoneBook[key]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
