namespace BaseProblems.Solutions.Quests.Array2;

public class Q1Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var visited = new bool[nums.Length + 1];
        var repeatNumber = 0;

        foreach (var num in nums)
        {
            if (visited[num])
                repeatNumber = num;
            visited[num] = true;
        }

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!visited[i])
                return [repeatNumber, i];
        }

        return [];
    }
}
