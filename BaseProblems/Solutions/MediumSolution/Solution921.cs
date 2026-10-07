namespace BaseProblems.Solutions.MediumSolution;

public class Solution921
{
    public int MinAddToMakeValid(string s)
    {
        var result = 0;
        var openBrackets = 0;

        foreach (var bracket in s)
        {
            if (bracket == '(')
                openBrackets++;
            else if (bracket == ')')
            {
                if (openBrackets == 0)
                    result++;
                else
                    openBrackets--;
            }
        }
        result += openBrackets;

        return result;
    }
}
