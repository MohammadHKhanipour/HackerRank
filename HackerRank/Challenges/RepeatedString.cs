using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class RepeatedString
    {
        static long GetResult(string inputString, long inputNum)
        {
            long counter = 0;
            long div = inputNum / (inputString.Length);
            int mod = Convert.ToInt32(inputNum % (inputString.Length));

            counter = inputString.Count(x => x == 'a');

            counter *= div;

            counter += inputString.Take(mod).Count(x => x == 'a');

            return counter;
        }

        public static void Run()
        {
            string inputString = Console.ReadLine();
            long inputNum = long.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(inputString,inputNum));
        }
    }
}
