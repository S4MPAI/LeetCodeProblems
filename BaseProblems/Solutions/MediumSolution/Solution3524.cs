using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3524 : BaseTestClass
{
    public long[] ResultArray(int[] nums, int k)
    {
        var dp = new int[nums.Length, k];
        dp[0, nums[0] % k] = 1;
        var result = new long[k];
        result[nums[0] % k] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            var remainder = nums[i] % k;

            for (var j = 0; j < k; j++)
            {
                var count = dp[i - 1, j];
                var productRemainder = j * remainder % k;
                result[productRemainder] += count;
                dp[i, productRemainder] += count;
            }

            result[remainder]++;
            dp[i, remainder]++;
        }

        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = int.Parse(Console.ReadLine());
        var c = ResultArray(a, b);

        Console.WriteLine(string.Join(" ", c));
    }
}
