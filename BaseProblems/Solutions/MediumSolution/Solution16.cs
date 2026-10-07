using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution16 : BaseTestClass
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var bestDistance = int.MaxValue;
        var result = 0;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[left] + nums[right] + nums[i];
                var distance = Math.Abs(sum - target);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                    result = sum;
                }

                if (sum < target)
                    left++;
                else if (sum > target)
                    right--;
                else
                    return result;
            }
        }

        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = int.Parse(Console.ReadLine());
        var c = ThreeSumClosest(a, b);
        Console.WriteLine(c);
    }
}
