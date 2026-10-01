namespace BaseProblems.Solutions.MediumSolution;

public class Solution1111
{
    public int[] MaxDepthAfterSplit(string seq)
    {
        var result = new int[seq.Length];
        var depth = 0;

        for (var i = 0; i < seq.Length; i++)
        {
            if (seq[i] == '(')
            {
                result[i] = depth % 2;
                depth++;
            }
            else if (seq[i] == ')')
            {
                depth--;
                result[i] = depth % 2;
            }
        }

        return result;
    }

    public int[] MaxDepthAfterSplitV2(string seq)
    {
        var result = new int[seq.Length];

        for (var i = 0; i < seq.Length; i++)
            result[i] = (i % 2) ^ (seq[i] == '(' ? 0 : 1);

        return result;
    }
}
