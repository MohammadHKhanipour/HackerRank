using System;

namespace HackerRank.Challenges
{
    class MarsExploration
    {
        static int GetResult (string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i = i + 3)
            {
                if (input[i] != 'S')
                    count++;
                if (input[i + 1] != 'O')
                    count++;
                if (input[i + 2] != 'S')
                    count++;
            }

            return count;
        }

        public static void Run()
        {
            Console.WriteLine(GetResult(Console.ReadLine()));
        }
    }
}
