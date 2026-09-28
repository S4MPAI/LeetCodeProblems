namespace BaseProblems.Solutions.EasySolution;

public class Solution1614
{
    public int MaxDepth(string s)
    {
        var depth = 0;
        var result = 0;

        foreach (var c in s)
        {
            if (c == '(')
                depth++;
            if (c == ')')
            {
                result = Math.Max(result, depth);
                depth--;
            }
        }

        return result;
    }
}
