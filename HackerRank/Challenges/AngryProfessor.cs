namespace HackerRank.Challenges;

class AngryProfessor
{
    static string GetResult(int limit, int[] arrivalTimes)
    {
        int earlyStudentsCount = arrivalTimes.Where(time => time < 1).Count();

        if (earlyStudentsCount >= limit)
            return "NO";
        return "YES";
    }

    public static void Run()
    {
        int testCases = Convert.ToInt32(Console.ReadLine());
        string[] results = new string[testCases];

        for (int i = 0; i < testCases; i++)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            int limit = inputs[1];

            int[] arrivalTimes = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            results[i] = GetResult(limit, arrivalTimes);
        }

        foreach (string item in results)
        {
            Console.WriteLine(item);
        }
    }
}
