using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution8 : BaseTestClass
{
    public int MyAtoi(string s)
    {
        s = s.Trim();

        if (string.IsNullOrEmpty(s))
            return 0;

        var sign = 1;
        var i = 0;
        if (s[0] == '+' || s[0] == '-')
        {
            sign = s[0] == '-' ? -1 : 1;
            i++;
        }

        var num = 0;
        while (i < s.Length && char.IsDigit(s[i]))
        {
            var digit = s[i] - '0';

            if (num > (int.MaxValue - digit) / 10)
                return sign > 0 ? int.MaxValue : int.MinValue;

            num = num * 10 + digit;
            i++;
        }

        return sign * num;
    }

    public override void Start()
    {
        var a = Console.ReadLine();
        var b = MyAtoi(a);
        Console.WriteLine(b);
    }
}
