namespace BaseProblems.Solutions.MediumSolution;

public class Solution678
{
    public bool CheckValidString(string s)
    {
        var openBrackets = new Stack<int>();
        var stars = new Stack<int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                openBrackets.Push(i);
            if (s[i] == '*')
                stars.Push(i);

            if (s[i] == ')')
                if (openBrackets.Count > 0)
                    openBrackets.Pop();
                else if (stars.Count > 0)
                    stars.Pop();
                else
                    return false;
        }

        while (openBrackets.Count > 0 && stars.Count > 0)
        {
            var openBracket = openBrackets.Pop();
            var star = stars.Pop();

            if (openBracket > star)
                return false;
        }

        return openBrackets.Count == 0;
    }

    public bool CheckValidStringV2(string s)
    {
        var openMin = 0;
        var openMax = 0;

        foreach (var c in s)
        {
            if (c == '(')
            {
                openMin++;
                openMax++;
            }
            else if (c == ')')
            {
                openMin--;
                openMax--;
            }
            else
            {
                openMin--;
                openMax++;
            }

            if (openMax < 0)
                return false;
            if (openMin < 0)
                openMin = 0;
        }

        return openMin == 0;
    }
}
