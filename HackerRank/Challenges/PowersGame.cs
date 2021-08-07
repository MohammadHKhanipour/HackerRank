using System;
using System.IO;

namespace HackerRank.Challenges
{
    class PowersGame
    {
        static string GetResult(int input) => input % 8 == 0 ? "Second" : "First";

        public static void Run()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int times = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string result = GetResult(n);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
