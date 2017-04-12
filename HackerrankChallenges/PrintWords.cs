using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankChallenges
{
    class PrintWords
    {
        public PrintWords(string s)
        {
            int wordCount = 1;
            string currentWord = wordCount.ToString() + ". ";
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s, i))
                {
                    Console.WriteLine(currentWord);
                    wordCount += 1;
                    currentWord = wordCount.ToString() + ". " + s[i].ToString();
                }
                else
                {
                    currentWord += s[i].ToString();
                }
            }
            Console.WriteLine(currentWord);
            Console.ReadLine();
        }
    }
}
