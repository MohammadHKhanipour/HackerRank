namespace HackerRank.Challenges;

class FindDigits
{
    static int GetResult(int number)
    {
        int divisors = 0;

        string numberString = number.ToString();

        foreach (char item in numberString)
        {
            if (Convert.ToInt32(item.ToString()) == 0)
                continue;
            else if (number % Convert.ToInt32(item.ToString()) == 0)
                divisors++;
        }

        return divisors;
    }

    public static void Run()
    {
        int times = Convert.ToInt32(Console.ReadLine());

        int[] results = new int[times];

        for (int i = 0; i < times; i++)
        {
            results[i] = GetResult(Convert.ToInt32(Console.ReadLine()));
        }

        foreach (int item in results)
        {
            Console.WriteLine(item);
        }
    }
}
