using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class SaveThePrisoner
    {
        static int GetResult(int numberOfPrisoners, int numberOfSweets, int chairNumber) => ((chairNumber - 1 + numberOfSweets - 1) % numberOfPrisoners) + 1;

        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] results = new int[count];

            for (int i = 0; i < count; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                int numberOfPrisoners = inputs[0];
                int numberOfSweets = inputs[1];
                int chairNumber = inputs[2];

                results[i] = GetResult(numberOfPrisoners, numberOfSweets, chairNumber);
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine(results[i]);
        }
    }
}
