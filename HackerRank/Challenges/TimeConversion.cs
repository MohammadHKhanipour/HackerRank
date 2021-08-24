using System;

namespace HackerRank.Challenges
{
    class TimeConversion
    {
        static string GetResult(string input) => DateTime.Parse(input).ToString("HH:mm:ss");

        public static void Run()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetResult(input));
        }
    }
}
