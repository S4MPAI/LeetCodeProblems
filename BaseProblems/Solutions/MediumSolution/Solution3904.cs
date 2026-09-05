using BaseProblems.Interfaces;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3904 : IStartable
{
    public int FirstStableIndex(int[] nums, int k)
    {
        var length = nums.Length;
        var suffMin = new int[length];
        suffMin[length - 1] = nums[length - 1];
        for (var i = length - 2; i >= 0; i--)
            suffMin[i] = Math.Min(nums[i], suffMin[i + 1]);

        var currentMax = 0;
        for (var i = 0; i < length; i++)
        {
            currentMax = Math.Max(currentMax, nums[i]);
            var score = currentMax - suffMin[i];

            if (score <= k)
                return i;
        }

        return -1;
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
}
