using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class CompareTheTriplets
    {
        static int[] GetResults(int[] aliceRating, int[] bobRating)
        {
            int[] points = {0,0};

            for (int i = 0; i < 3; i++)
            {
                if (aliceRating[i] > bobRating[i])
                    points[0]++;
                else if (aliceRating[i] < bobRating[i])
                    points[1]++;
                else
                    continue;
            }

            return points;
        }

        public static void Run()
        {
            int[] aliceRating = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] bobRating = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] results = GetResults(aliceRating, bobRating);

            Console.WriteLine($"{results[0]} {results[1]}");
        }
    }
}
