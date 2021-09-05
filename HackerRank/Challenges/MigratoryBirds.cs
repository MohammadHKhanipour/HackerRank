using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Challenges
{
    class MigratoryBirds
    {
        static int GetResult(int[] inputBirds)
        {
            Dictionary<int, int> birds = new Dictionary<int, int>();

            foreach (int item in inputBirds.Distinct().ToList())
            {
                birds.Add(item, inputBirds.Count(x => x == item));
            }

            Dictionary<int, int> any = birds.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            if (any.ElementAt(0).Value == any.ElementAt(1).Value)
                if (any.ElementAt(0).Key > any.ElementAt(1).Key)
                    return any.ElementAt(1).Key;
            return any.ElementAt(0).Key;
        }

        public static void Run()
        {
            int birdsCount = Convert.ToInt32(Console.ReadLine());
            int[] birds = new int[birdsCount];

            birds = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(GetResult(birds));
        }
    }
}
