using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution1541 : BaseTestClass
{
    public int MinInsertions(string s)
    {
        var opened = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                opened++;
            else
            {
                var next = i + 1;

                if (opened > 0)
                    opened--;
                else
                    result++;

                if (next < s.Length && s[next] == ')')
                {
                    i++;
                    continue;
                }

                result++;
            }
        }

        result += opened * 2;
        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine();
        var b = MinInsertions(a);
        Console.WriteLine(a);
    }
}
