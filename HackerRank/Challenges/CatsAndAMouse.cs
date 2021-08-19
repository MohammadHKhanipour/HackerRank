using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Challenges
{
    class CatsAndAMouse
    {
        static string GetResult(int catAPos, int catBPos, int mousePos)
        {
            if (Math.Abs(catBPos - mousePos) > Math.Abs(catAPos - mousePos))
                return "Cat A";
            else if (Math.Abs(catBPos - mousePos) < Math.Abs(catAPos - mousePos))
                return "Cat B";
            else
                return "Mouse C";
        }

        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            List<int[]> arrays = new List<int[]>();

            for (int i = 0; i < count; i++)
            {
                arrays.Add(Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray());
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(GetResult(arrays[i][0], arrays[i][1], arrays[i][2]));
            }
        }
    }
}
