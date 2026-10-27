namespace BaseProblems.Solutions.Quests.Array1;

public class Q2Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[n * 2];
        for (var i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[n + i];
        }

        return result;
    }
}
