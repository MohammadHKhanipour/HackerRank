using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Challenges
{
    class MakingAnagrams
    {
        static int getResult(string input1, string input2)
        {
            int counter = 0;

            Dictionary<char, int> alphabetCount = new Dictionary<char, int> {
                {'a',0},
                {'b',0},
                {'c',0},
                {'d',0},
                {'e',0},
                {'f',0},
                {'g',0},
                {'h',0},
                {'i',0},
                {'j',0},
                {'k',0},
                {'l',0},
                {'m',0},
                {'n',0},
                {'o',0},
                {'p',0},
                {'q',0},
                {'r',0},
                {'s',0},
                {'t',0},
                {'u',0},
                {'v',0},
                {'w',0},
                {'x',0},
                {'y',0},
                {'z',0}
            };

            foreach (char item in input1)
                alphabetCount[item]++;

            foreach (char item in input2)
                alphabetCount[item]--;

            counter = alphabetCount.Sum(x => Math.Abs(x.Value));

            return counter;
        }

        public static void Run()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(getResult(input1, input2));
        }
    }
}
