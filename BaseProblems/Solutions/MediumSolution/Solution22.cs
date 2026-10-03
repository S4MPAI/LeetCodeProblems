using System.Text;
using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution22 : BaseTestClass
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        var buffer = new StringBuilder(n * 2);
        var stack = new Stack<(char bracket, int openBrackets, int closeBrackets)>();
        stack.Push(('(', 1, 0));

        while (stack.Count != 0)
        {
            var info = stack.Pop();
            var length = info.openBrackets + info.closeBrackets;
            buffer[length - 1] = info.bracket;

            if (length == n * 2)
                result.Add(buffer.ToString());

            if (info.openBrackets < n)
                stack.Push(('(', info.openBrackets + 1, info.closeBrackets));

            if (info.closeBrackets < info.openBrackets)
                stack.Push((')', info.openBrackets, info.closeBrackets + 1));
        }

        return result;
    }

    public override void Start()
    {
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine(GenerateParenthesis(a));
    }
}
