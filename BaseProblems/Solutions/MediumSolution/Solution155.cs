namespace BaseProblems.Solutions.MediumSolution;

public class Solution155 { }

public class MinStack
{
    private readonly Stack<long> stack = new();
    private long minElement = 0;

    public void Push(int value)
    {
        if (stack.Count == 0)
        {
            stack.Push(value);
            minElement = value;
        }
        else if (value < minElement)
        {
            stack.Push(value * 2L - minElement);
            minElement = value;
        }
        else
            stack.Push(value);
    }

    public void Pop()
    {
        var top = stack.Pop();

        if (top < minElement)
            minElement = 2 * minElement - top;
    }

    public int Top()
    {
        var top = stack.Peek();

        return top >= minElement ? (int)top : (int)minElement;
    }

    public int GetMin() => (int)minElement;
}
