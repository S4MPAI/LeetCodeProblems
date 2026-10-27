namespace BaseProblems.Solutions.Quests.MonotonicStack;

public class Q1Solution
{
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();

        for (var i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
                prices[stack.Pop()] -= prices[i];

            stack.Push(i);
        }

        return prices;
    }
}
