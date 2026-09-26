using System.Text;
using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution1807 : BaseTestClass
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var keyToValue = knowledge.ToDictionary(x => x[0], x => x[1]);
        var result = new StringBuilder();

        var right = -1;
        var i = 0;
        while (i < s.Length)
        {
            while (i < s.Length && s[i] != '(')
                i++;

            var left = i;
            result.Append(s.AsSpan(right + 1, left - right - 1));

            if (i >= s.Length)
                break;

            while (s[i] != ')')
                i++;
            right = i;

            var key = s.Substring(left + 1, right - left - 1);
            if (keyToValue.TryGetValue(key, out var value))
                result.Append(value);
            else
                result.Append('?');
            i++;
        }

        return result.ToString();
    }

    public override void Start()
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine().Split();
        var c = b.Select((x, i) => (x, i))
            .GroupBy(x => x.i / 2)
            .Select(IList<string> (x) => x.Select(tuple => tuple.x).ToList())
            .ToList();
        Console.WriteLine(Evaluate(a, c));
    }
}
