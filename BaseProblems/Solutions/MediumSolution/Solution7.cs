using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution7 : IStartable
{
    public void Start()
    {
        var a = int.Parse(Console.ReadLine());
        var b = Reverse(a);
        Console.WriteLine(b);
    }

    public int Reverse(int x)
    {
        var result = 0;
        var oldResult = result;

        var sign = Math.Sign(x);

        while (x != 0)
        {
            var remain = Math.Abs(x % 10);
            x /= 10;

            oldResult = result;
            result = result * 10 + remain;
        }
        if (result / 10 != oldResult)
            return 0;

        return sign * result;
    }
}
