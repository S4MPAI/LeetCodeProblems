namespace BaseProblems.Solutions.Quests.Array1;

public class Q1Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var n = nums.Length;
        Array.Resize(ref nums, n * 2);

        for (var i = 0; i < n; i++)
            nums[n + i] = nums[i];

        return nums;
    }
}
