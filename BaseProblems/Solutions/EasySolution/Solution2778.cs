using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.EasySolution;

public class Solution2778 : BaseTestClass
{
    public int SumOfSquares(int[] nums)
    {
        var n = (int)Math.Sqrt(nums.Length);
        var count = nums.Length;
        var result = 0;
        for (var i = 0; i < n; i++)
        {
            var firstDivider = i + 1;
            if (count % firstDivider == 0)
                result += nums[i] * nums[i];

            var secondDivider = count / firstDivider;
            if (count % secondDivider == 0 && secondDivider != firstDivider)
                result += nums[secondDivider - 1] * nums[secondDivider - 1];
        }

        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = SumOfSquares(a);
        Console.WriteLine(b);
    }
}
