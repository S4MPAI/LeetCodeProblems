using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution1658 : BaseTestClass
{
    public int MinOperations(int[] nums, int x)
    {
        var right = 0;
        var left = 0;
        var sum = nums.Sum();
        var result = int.MaxValue;

        while (left < nums.Length && left <= right)
        {
            if (sum == x)
                result = Math.Min(result, left + nums.Length - right);

            if (sum >= x)
            {
                if (right >= nums.Length)
                    break;
                sum -= nums[right++];
            }
            else
                sum += nums[left++];
        }

        return result == int.MaxValue ? -1 : result;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = int.Parse(Console.ReadLine());
        var c = MinOperations(a, b);
        Console.WriteLine(c);
    }
}
