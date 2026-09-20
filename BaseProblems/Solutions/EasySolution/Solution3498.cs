namespace BaseProblems.Solutions.EasySolution;

public class Solution3498
{
    public int ReverseDegree(string s)
    {
        var sum = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var alphabetIndex = 'z' - s[i] + 1;
            sum += alphabetIndex * (i + 1);
        }

        return sum;
    }
}
