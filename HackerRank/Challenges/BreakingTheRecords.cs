using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class BreakingTheRecords
    {
        static int[] GetResults(int[] scores)
        {
            int[] results = { 0, 0 };
            int highScore = scores[0];
            int lowScore = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > highScore)
                {
                    results[0]++;
                    highScore = scores[i];
                }
                if (scores[i] < lowScore)
                {
                    results[1]++;
                    lowScore = scores[i];
                }
            }
            return results;
        }

        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] inputs = new int[count];

            inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] results = GetResults(inputs);

            Console.WriteLine($"{results[0]} {results[1]}");
        }
    }
}
