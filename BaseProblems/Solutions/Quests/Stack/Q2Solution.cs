namespace BaseProblems.Solutions.Quests.Stack;

public class Q2Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (token.Length == 1 && token[0] < '0')
            {
                var (a, b) = PopTwoDigits(stack);
                var c = token[0] switch
                {
                    '+' => a + b,
                    '-' => b - a,
                    '*' => a * b,
                    '/' => b / a,
                };
                stack.Push(c);
            }
            else
                stack.Push(int.Parse(token));
        }

        return stack.Pop();
    }

    private static (int first, int second) PopTwoDigits(Stack<int> stack) =>
        (stack.Pop(), stack.Pop());
}
