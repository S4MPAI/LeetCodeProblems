namespace BaseProblems.Solutions.EasySolution;

public class Solution20
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var openBracketToCloseBracket = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
        };

        foreach (var t in s)
        {
            if (openBracketToCloseBracket.ContainsKey(t))
                stack.Push(t);
            else if (!stack.TryPop(out var c) || t != openBracketToCloseBracket[c])
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}
