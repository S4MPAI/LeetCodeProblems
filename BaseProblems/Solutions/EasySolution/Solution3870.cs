using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.EasySolution;

public class Solution3870 : IStartable
{
    public void Start()
    {
        var n = int.Parse(Console.ReadLine());
        var result = CountCommas(n);
        Console.WriteLine(result);
    }

    public int CountCommas(int n)
    {
        if (n < 1000)
            return 0;

        return n - 999;
    }
}
