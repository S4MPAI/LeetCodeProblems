namespace BaseProblems.Solutions.Quests.Array1;

public class Q3Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var result = 0;
        var repeats = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                repeats++;
                result = Math.Max(result, repeats);
            }
            else
                repeats = 0;
        }

        return result;
    }
}
