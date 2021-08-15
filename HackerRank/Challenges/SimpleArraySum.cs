using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class SimpleArraySum
    {
        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            array = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(array.Sum());
        }
    }
}
