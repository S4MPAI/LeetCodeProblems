namespace BaseProblems.Solutions.Quests.Array2;

public class Q3Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var n = nums.Length;
        for (var i = 0; i < n; i++)
        {
            if (nums[i] == i + 1)
                continue;
            var index = nums[i] - 1;
            nums[i] = 0;
            while (index >= 0 && nums[index] != index + 1)
                (index, nums[index]) = (nums[index] - 1, index + 1);
        }

        var result = new List<int>();
        for (var i = 0; i < n; i++)
            if (nums[i] == 0)
                result.Add(i + 1);
        return result;
    }
}
