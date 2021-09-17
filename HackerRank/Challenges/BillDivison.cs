using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Challenges
{
    class BillDivison
    {
        static void GetResult(int excluded, List<int> itemsPrices, int paidAmount)
        {
            itemsPrices.RemoveAt(excluded);

            if (itemsPrices.Sum() / 2 == paidAmount)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(paidAmount - itemsPrices.Sum() / 2);
        }

        public static void Run()
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            List<int> itemsPrices = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            int paidAmount = Convert.ToInt32(Console.ReadLine());

            GetResult(inputs[1], itemsPrices, paidAmount);
        }
    }
}
