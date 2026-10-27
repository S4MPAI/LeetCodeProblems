namespace BaseProblems.Solutions.EasySolution;

public class Solution2089
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        var targetCount = 0;
        var prefixNumbersCount = 0;
        foreach (var num in nums)
        {
            if (num == target)
                targetCount++;
            else if (num < target)
                prefixNumbersCount++;
        }

        var result = new int[targetCount];
        for (var i = 0; i < targetCount; i++)
            result[i] = prefixNumbersCount + i;

        return result;
    }
}
