namespace BaseProblems.Solutions.Quests.MonotonicStack;

public class Q3Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var stack = new Stack<int>();
        var result = 0;

        for (var i = 0; i < heights.Length; i++)
        {
            var nextIndex = i;
            while (stack.Count != 0 && heights[stack.Peek()] > heights[i])
            {
                var j = stack.Pop();
                result = Math.Max(result, (i - j) * heights[j]);
                nextIndex = j;
            }

            stack.Push(nextIndex);
            heights[nextIndex] = heights[i];
        }

        while (stack.Count > 0)
        {
            var j = stack.Pop();
            result = Math.Max(result, (heights.Length - j) * heights[j]);
        }

        return result;
    }
}
