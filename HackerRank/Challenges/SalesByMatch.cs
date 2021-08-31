using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Challenges
{
    class SalesByMatch
    {
        static int GetResult(List<int> socks)
        {
            int pairCounter = 0;
            List<int> tempList = new List<int>();

            foreach (int item in socks)
            {
                if (tempList.Contains(item))
                    continue;
                pairCounter += socks.Count(x => x == item) / 2;
                tempList.Add(item);
            }

            return pairCounter;
        }

        public static void Run()
        {
            _ = Console.ReadLine();

            List<int> inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            Console.WriteLine(GetResult(inputs));
        }
    }
}
