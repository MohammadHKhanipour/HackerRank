using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class TheHurdleRace
    {
        static int GetResult(int maxJump, int[] inputs)
        {
            int[] hurdles = inputs.OrderByDescending(x=>x).ToArray();

            if (hurdles[0] <= maxJump)
                return 0;
            return hurdles[0] - maxJump;
        }

        public static void Run()
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int maxJump = inputs[1];

            int[] hurdles = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(GetResult(maxJump, hurdles));
        }
    }
}
