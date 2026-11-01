namespace BaseProblems.Solutions.EasySolution;

public class Solution3190
{
    public int MinimumOperations(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            if (num % 3 != 0)
                result += 1;
        }

        return result;
    }
}
