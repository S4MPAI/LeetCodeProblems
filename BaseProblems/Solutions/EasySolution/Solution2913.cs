namespace BaseProblems.Solutions.EasySolution;

public class Solution2913
{
    public int SumCounts(IList<int> nums)
    {
        var n = nums.Count;
        var result = 0;

        var hashset = new HashSet<int>();
        for (var i = 0; i < n; i++)
        {
            hashset.Clear();
            for (var j = i; j < n; j++)
            {
                hashset.Add(nums[j]);
                var count = hashset.Count;
                result += count * count;
            }
        }

        return result;
    }
}
