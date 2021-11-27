namespace HackerRank.Challenges;

class AppleAndOrange
{
    static int[] GetResults(int houseStartingPoint, int houseEndingPoint, int appleTreeLocation, int orangeTreeLocation, int[] applesThrownLocations, int[] orangesThrownLocations)
    {
        int[] results = { 0, 0 };

        for (int i = 0; i < applesThrownLocations.Length; i++)
            if (applesThrownLocations[i] + appleTreeLocation <= houseEndingPoint && applesThrownLocations[i] + appleTreeLocation >= houseStartingPoint)
                results[0]++;
        for (int i = 0; i < orangesThrownLocations.Length; i++)
            if (orangesThrownLocations[i] + orangeTreeLocation <= houseEndingPoint && orangesThrownLocations[i] + orangeTreeLocation >= houseStartingPoint)
                results[1]++;

        return results;
    }

    public static void Run()
    {
        var inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int houseStartingPoint = inputs[0];
        int houseEndingPoint = inputs[1];

        inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int appleTreeLocation = inputs[0];
        int orangeTreeLocation = inputs[1];

        inputs = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int applesCount = inputs[0];
        int orangesCount = inputs[1];

        int[] applesThrownLocations = new int[applesCount];
        int[] orangesThrownLocations = new int[orangesCount];

        applesThrownLocations = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        orangesThrownLocations = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        int[] results = new int[2];
        results = GetResults(houseStartingPoint, houseEndingPoint, appleTreeLocation, orangeTreeLocation, applesThrownLocations, orangesThrownLocations);

        Console.WriteLine(results[0]);
        Console.WriteLine(results[1]);
    }
}
