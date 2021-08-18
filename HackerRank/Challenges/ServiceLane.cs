using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class ServiceLane
    {
        static int[] GetResults(int[] width, int[,] cases, int casesCount)
        {
            int[] result = new int[casesCount];

            for (int i = 0; i < casesCount; i++)
            {
                result[i] = width.Skip(cases[i, 0]).Take(cases[i, 1] - cases[i, 0] + 1).Min();
            }

            return result;
        }

        public static void Run()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int inputsCount = Convert.ToInt32(inputs[0]);
            int casesCount = Convert.ToInt32(inputs[1]);

            int[] width = new int[inputsCount];

            inputs = Console.ReadLine().Split(' ');

            width = Array.ConvertAll(inputs, int.Parse);

            int[,] cases = new int[casesCount, 2];

            string[] temp;

            for (int i = 0; i < casesCount; i++)
            {
                temp = Console.ReadLine().Split(' ');
                cases[i, 0] = Convert.ToInt32(temp[0]);
                cases[i, 1] = Convert.ToInt32(temp[1]);
            }

            var result = GetResults(width, cases, casesCount);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
