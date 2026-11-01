namespace BaseProblems.Solutions.MediumSolution;

public class Solution453
{
    public int MinMoves(int[] nums)
    {
        var min = nums[0];
        var sum = 0;

        foreach (var num in nums)
        {
            sum += num;
            if (min > num)
                min = num;
        }

        return sum - min * nums.Length;
    }
}
