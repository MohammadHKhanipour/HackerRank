using System;

namespace HackerRank.Challenges
{
    class ViralAdvertising
    {
        static int GetResult(int dayNumber)
        {
            int temp = 2;
            int a = 2;
            for (int i = 1; i < dayNumber; i++)
            {
                a *= 3;
                a /= 2;
                temp += a;
            }

            return temp;
        }

        public static void Run()
        {
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetResult(dayNumber));
        }
    }
}
