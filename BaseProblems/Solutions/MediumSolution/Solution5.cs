using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution5 : IStartable
{
    public string LongestPalindrome(string s)
    {
        var bestPalindrome = (0, 0);
        var dm = new bool[s.Length, s.Length];
        for (var i = 0; i < s.Length; i++)
            dm[i, i] = true;
        for (var i = 0; i < s.Length - 1; i++)
        {
            var isPalindrome = s[i] == s[i + 1];
            dm[i, i + 1] = isPalindrome;

            if (isPalindrome)
                bestPalindrome = (i, i + 1);
        }

        for (var i = 2; i < s.Length; i++)
        {
            for (var j = 0; j + i < s.Length; j++)
            {
                var isPalindrome = dm[j + 1, j + i - 1] && s[j] == s[i + j];
                dm[j, j + i] = isPalindrome;

                if (isPalindrome)
                    bestPalindrome = (j, j + i);
            }
        }

        return s[bestPalindrome.Item1..(bestPalindrome.Item2 + 1)];
    }

    public void Start()
    {
        var a = Console.ReadLine();
        var b = LongestPalindrome(a);

        Console.WriteLine(b);
    }
}
