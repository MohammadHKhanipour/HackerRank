using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class NumberLineJumps
    {
        static string GetResult(int firstKangarooX, int firstKangarooV , int secondKangarooX, int secondKangarooV)
        {
            if (firstKangarooV > secondKangarooV)
                if ((secondKangarooX - firstKangarooX) % (secondKangarooV - firstKangarooV) == 0)
                    return "YES";
            return "NO";
        }

        public static void Run()
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine(GetResult(inputs[0], inputs[1], inputs[2], inputs[3]));
        }
    }
}
