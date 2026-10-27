using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3727 : BaseTestClass
{
    public long MaxAlternatingSum(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            nums[i] *= nums[i];
        Array.Sort(nums);
        var sum = 0L;
        var n = nums.Length;

        for (var i = 0; i < n / 2; i++)
            sum -= nums[i];

        for (var i = n / 2; i < n; i++)
            sum += nums[i];

        return sum;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MaxAlternatingSum(a));
    }
}
