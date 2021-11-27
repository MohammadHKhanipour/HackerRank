namespace HackerRank.Challenges;

class PlusMinus
{
    static string[] GetResults(float[] inputs)
    {
        string[] counters = new string[3];

        float[] localInputs = inputs;

        counters[0] = (float.Parse(localInputs.Where(x => x > 0).Count().ToString()) / float.Parse(localInputs.Length.ToString())).ToString("0.000000");
        counters[1] = (float.Parse(localInputs.Where(x => x < 0).Count().ToString()) / float.Parse(localInputs.Length.ToString())).ToString("0.000000");
        counters[2] = (float.Parse(localInputs.Where(x => x == 0).Count().ToString()) / float.Parse(localInputs.Length.ToString())).ToString("0.000000");

        return counters;
    }

    public static void Run()
    {
        _ = Console.ReadLine();

        float[] inputs = Console.ReadLine().Split(' ').Select(x => float.Parse(x)).ToArray();

        string[] results = GetResults(inputs);

        foreach (string item in results)
        {
            Console.WriteLine(item);
        }
    }
}
