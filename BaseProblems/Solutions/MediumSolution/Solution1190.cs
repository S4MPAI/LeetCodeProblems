using System.Text;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution1190
{
    public string ReverseParentheses(string s)
    {
        var openBrackets = new Stack<int>();
        var inBracketToOut = new Dictionary<int, int>();
        var result = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                openBrackets.Push(i);
            if (s[i] == ')')
            {
                var openBracket = openBrackets.Pop();
                inBracketToOut[openBracket] = i;
                inBracketToOut[i] = openBracket;
            }
        }

        var index = 0;
        var direction = 1;
        while (index < s.Length)
        {
            if (inBracketToOut.TryGetValue(index, out var value))
            {
                index = value;
                direction *= -1;
            }
            else
                result.Append(s[index]);
            index += direction;
        }

        return result.ToString();
    }
}
