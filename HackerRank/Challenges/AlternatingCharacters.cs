using System;

namespace HackerRank.Challenges
{
    class AlternatingCharacters
    {
        static int result(string input)
        {
            int cursor = 0;
            int counter = 0;
            foreach (char item in input)
            {
                if (++cursor < input.Length)
                    if (item == input[cursor])
                        counter++;
            }
            return counter;
        }

        public static void Run()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int[] res = new int[input];

            for (int i = 0; i < input; i++)
            {
                res[i] = result(Console.ReadLine());
            }

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
