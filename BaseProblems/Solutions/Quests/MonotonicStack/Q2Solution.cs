namespace BaseProblems.Solutions.Quests.MonotonicStack;

public class Q2Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var stack = new Stack<int>();

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                var j = stack.Pop();
                temperatures[j] = i - j;
            }

            stack.Push(i);
        }

        while (stack.Count > 0)
            temperatures[stack.Pop()] = 0;

        return temperatures;
    }
}
