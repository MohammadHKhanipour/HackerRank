using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class JumpingOnTheClouds
    {
        static int GetResult(int[] input)
        {
            int counter = 0;
            int i = 0;
            while (i < (input.Length - 1))
            {
                if ((i + 2) != input.Length && input[i + 2] == 0)
                {
                    i += 2;
                    counter += 1;
                }
                else
                {
                    i += 1;
                    counter += 1;
                }
            }
            return counter;
        }

        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            array = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(GetResult(array));
        }
    }
}
