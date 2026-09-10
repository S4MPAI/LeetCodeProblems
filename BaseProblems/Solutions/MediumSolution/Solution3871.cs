using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3871 : BaseTestClass
{
    public override void Start()
    {
        var a = long.Parse(Console.ReadLine());
        var b = CountCommas(a);
        Console.WriteLine(b);
    }

    public long CountCommas(long n)
    {
        var a = n;
        var count = 0L;
        var degree = 1000L;
        var i = 1;

        while (a >= 1000)
        {
            a /= 1000;

            var newDegree = degree * 1000;
            var c = a >= 1000 ? (newDegree - 1) : n;

            count += i * (c - degree + 1);
            degree = newDegree;
            i++;
        }

        return count;
    }
}
