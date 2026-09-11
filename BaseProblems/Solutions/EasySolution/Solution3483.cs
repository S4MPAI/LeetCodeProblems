using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.EasySolution;

public class Solution3483 : BaseTestClass
{
    public int TotalNumbers(int[] digits)
    {
        var countByDigit = new Dictionary<int, int>();
        var evenNumbers = new HashSet<int>();
        foreach (var digit in digits)
        {
            countByDigit.TryAdd(digit, 0);
            countByDigit[digit]++;

            if (digit % 2 == 0)
                evenNumbers.Add(digit);
        }

        var result = 0;
        foreach (var number in evenNumbers)
        {
            countByDigit[number]--;
            result += TotalNumbersCore(countByDigit);
            countByDigit[number]++;
        }

        return result;
    }

    private static int TotalNumbersCore(Dictionary<int, int> countByDigit)
    {
        var result = 0;
        foreach (var digit in countByDigit.Keys.Where(digit => countByDigit[digit] > 0))
        {
            countByDigit[digit]--;
            result += countByDigit.Count(x => x.Value > 0 && x.Key != 0);
            countByDigit[digit]++;
        }

        return result;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = TotalNumbers(a);
        Console.WriteLine(b);
    }
}
