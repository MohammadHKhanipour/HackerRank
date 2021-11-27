namespace HackerRank.Challenges;

class BeautifulDaysAtTheMovies
{
    static int GetResult(int startScope, int endScope, int number)
    {
        int count = 0;
        int reversedNumber;
        for (int i = startScope; i <= endScope; i++)
        {
            reversedNumber = i.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');

            if (Math.Abs(i - reversedNumber) % number == 0)
                count++;
        }
        return count;
    }

    public static void Run()
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        Console.WriteLine(GetResult(inputs[0], inputs[1], inputs[2]));
    }
}
