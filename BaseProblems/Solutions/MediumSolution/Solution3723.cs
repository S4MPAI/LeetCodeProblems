using System.Text;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3723
{
    public string MaxSumOfSquares(int num, int sum)
    {
        if (sum > num * 9)
            return "";

        var result = new StringBuilder();
        result.Append('9', sum / 9);
        var r = sum % 9;
        if (r > 0)
            result.Append((char)('0' + r));

        result.Append('0', num - result.Length);

        return result.ToString();
    }
}
