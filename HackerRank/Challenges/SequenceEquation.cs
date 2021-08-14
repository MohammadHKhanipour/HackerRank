using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class SequenceEquation
    {
        static int[] GetResult(int[] inputs)
        {
            int[] results = new int[inputs.Length];

            int[] indexes = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                int num = inputs[i];
                indexes[num - 1] = i + 1;
            }

            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = indexes[indexes[i] - 1];
            }

            return results;
        }

        public static void Run()
        {
            int inputCount = Convert.ToInt32(Console.ReadLine());

            int[] inputs = new int[inputCount];

            inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int[] results = GetResult(inputs);

            foreach (int item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
