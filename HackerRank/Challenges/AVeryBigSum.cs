namespace HackerRank.Challenges;

class AVeryBigSum
{
    public static void Run()
    {
        Console.WriteLine("TEST");
        _ = Console.ReadLine();

        long[] numbers = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

        Console.WriteLine(numbers.Sum());
    }
}
