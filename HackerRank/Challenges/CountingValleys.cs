namespace HackerRank.Challenges;

class CountingValleys
{
    static int GetResult(string route)
    {
        List<char> path = new List<char>();
        path = route.ToCharArray().ToList();
        int level = 0;
        int valleyCounter = 0;
        for (int i = 0; i < path.Count; i++)
        {
            switch (path[i])
            {
                case 'U':
                    level++;
                    break;
                case 'D':
                    level--;
                    break;
            }
            if (level == 0 && path[i] == 'U')
            {
                valleyCounter++;
            }
        }
        return valleyCounter;
    }

    public static void Run()
    {
        _ = Console.ReadLine();

        string route = Console.ReadLine();

        Console.WriteLine(GetResult(route));
    }
}
