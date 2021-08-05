﻿using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class BirthdayCakeCandles
    {
        static int result(int[] input)
        {
            int max = input.Max();
            return input.Count(x => x == max);
        }

        public static void Run()
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            array = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();

            Console.WriteLine(result(array));
        }
    }
}