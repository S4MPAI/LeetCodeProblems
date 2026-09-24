namespace BaseProblems.Solutions.EasySolution;

public class Solution3550
{
    public int SmallestIndex(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (SumDigits(nums[i]) == i)
                return i;
        }

        return -1;
    }

    private static int SumDigits(int num)
    {
        var result = 0;

        while (num > 0)
        {
            result += num % 10;
            num /= 10;
        }

        return result;
    }
}
