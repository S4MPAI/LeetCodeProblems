namespace BaseProblems.Solutions.Quests.Array2;

public class Q2Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var numsRepeats = new int[101];

        foreach (var num in nums)
            numsRepeats[num]++;

        var prefix = 0;
        for (var i = 0; i < numsRepeats.Length; i++)
        {
            var repeats = numsRepeats[i];
            numsRepeats[i] = prefix;
            prefix += repeats;
        }

        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            result[i] = numsRepeats[nums[i]];

        return result;
    }
}
