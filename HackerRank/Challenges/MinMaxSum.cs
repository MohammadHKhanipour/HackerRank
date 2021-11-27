namespace HackerRank.Challenges;

class MinMaxSum
{
    static string GetResult(long[] numbers) => $"{numbers.Sum() - numbers.Max()} {numbers.Sum() - numbers.Min()}";

    public static void Run()
    {
        long[] inputs = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

        Console.WriteLine(GetResult(inputs));
    }
}
