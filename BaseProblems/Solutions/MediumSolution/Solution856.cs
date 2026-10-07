using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution856 : BaseTestClass
{
    public int ScoreOfParentheses(string s)
    {
        var multiply = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var bracket = s[i];
            switch (bracket)
            {
                case '(':
                    multiply = (multiply << 1) + (multiply == 0 ? 1 : 0);
                    break;
                case ')':
                {
                    if (s[i - 1] == '(')
                        result += multiply;
                    multiply >>= 1;
                    break;
                }
            }
        }

        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine();
        var b = ScoreOfParentheses(a);
        Console.WriteLine(b);
    }
}
