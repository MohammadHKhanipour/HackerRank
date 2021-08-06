using System;
using System.Linq;

namespace HackerRank.Challenges
{
    class LibraryFine
    {
        public static int GetResult(int[] returnedDate, int[] recievedDate)
        {
            if (returnedDate[2] > recievedDate[2])
                return 10000;
            else if (returnedDate[2] == recievedDate[2] && returnedDate[1] > recievedDate[1])
                return 500 * (returnedDate[1] - recievedDate[1]);
            else if (returnedDate[2] == recievedDate[2] && returnedDate[1] == recievedDate[1] && returnedDate[0] > recievedDate[0])
                return 15 * (returnedDate[0] - recievedDate[0]);
            else
                return 0;
        }

        public static void Run()
        {
            int[] returnedDate = new int[3];
            int[] recievedDate = new int[3];

            returnedDate = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            recievedDate = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(GetResult(returnedDate, recievedDate));
        }
    }
}
