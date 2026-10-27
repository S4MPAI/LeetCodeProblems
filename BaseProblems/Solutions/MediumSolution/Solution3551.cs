using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3551 : BaseTestClass
{
    public int MinSwaps(int[] nums)
    {
        var n = nums.Length;
        var sumsOfDigits = new int[n];
        var indexes = new int[n];
        for (var i = 0; i < n; i++)
            indexes[i] = i;

        for (var i = 0; i < n; i++)
        {
            var value = nums[i];
            while (value > 0)
            {
                sumsOfDigits[i] += value % 10;
                value /= 10;
            }
        }

        indexes.Sort(
            (a, b) =>
            {
                var keyCompare = sumsOfDigits[a].CompareTo(sumsOfDigits[b]);
                return keyCompare != 0 ? keyCompare : nums[a].CompareTo(nums[b]);
            }
        );

        var visited = new bool[n];
        var result = n;
        for (var i = 0; i < n; i++)
        {
            if (visited[i])
                continue;
            result--;
            var index = i;
            while (!visited[index])
            {
                visited[index] = true;
                index = indexes[index];
            }
        }

        return result;
    }

    public override void Start()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = MinSwaps(nums);
        Console.WriteLine(b);
    }
}
