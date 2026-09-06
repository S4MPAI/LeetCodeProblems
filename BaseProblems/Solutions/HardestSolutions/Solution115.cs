using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.HardestSolutions;

public class Solution115 : IStartable
{
    public int NumDistinct(string s, string t)
    {
        var prefixes = new int[t.Length + 1];
        prefixes[0] = 1;
        var charToIndexes = new Dictionary<char, List<int>>();
        for (var i = t.Length - 1; i >= 0; i--)
        {
            var c = t[i];
            if (!charToIndexes.ContainsKey(c))
                charToIndexes.Add(c, new List<int>());
            charToIndexes[c].Add(i);
        }

        foreach (var c in s)
        {
            if (!charToIndexes.ContainsKey(c))
                continue;

            var indexes = charToIndexes[c];

            foreach (var index in indexes)
                prefixes[index + 1] += prefixes[index];
        }

        return prefixes[^1];
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
}
