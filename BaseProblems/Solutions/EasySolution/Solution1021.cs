using System.Text;

namespace BaseProblems.Solutions.EasySolution;

public class Solution1021
{
    public string RemoveOuterParentheses(string s)
    {
        var open = 0;
        var result = new StringBuilder();

        foreach (var bracket in s)
        {
            if (bracket == '(')
            {
                open++;
                if (open > 1)
                    result.Append(bracket);
            }
            else
            {
                if (open > 1)
                    result.Append(bracket);
                open--;
            }
        }

        return result.ToString();
    }
}
