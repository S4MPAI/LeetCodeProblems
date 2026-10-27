namespace BaseProblems.Solutions.Quests.Stack;

public class Q1Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var targetN = target.Length;
        var result = new List<string>(targetN + (n - targetN) * 2);

        var lastElement = 0;
        foreach (var element in target)
        {
            for (var i = lastElement + 1; i < element; i++)
            {
                result.Add("Push");
                result.Add("Pop");
            }
            result.Add("Push");
            lastElement = element;
        }

        return result;
    }
}
