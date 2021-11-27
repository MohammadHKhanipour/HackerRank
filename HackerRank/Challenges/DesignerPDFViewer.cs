namespace HackerRank.Challenges;

class DesignerPDFViewer
{
    static int GetResult(int[] heights, string word)
    {
        Dictionary<char, int> alphabetValues = new Dictionary<char, int>();
        int i = 0;
        int wordLength = word.Length;
        List<int> wordHeights = new List<int>();

        for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
        {
            alphabetValues.Add(alphabet, heights[i]);
            i++;
        }

        foreach (char item in word)
        {
            wordHeights.Add(alphabetValues[item]);
        }

        return wordHeights.Max() * wordLength;
    }

    public static void Run()
    {
        int[] heights = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        string word = Console.ReadLine();

        Console.WriteLine(GetResult(heights, word));
    }
}
