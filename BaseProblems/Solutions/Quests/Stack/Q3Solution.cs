namespace BaseProblems.Solutions.Quests.Stack;

public class Q3Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        var result = new int[n];
        var stack = new Stack<int>();
        stack.Push(0);
        var lastTimestamp = 0;
        foreach (var log in logs)
        {
            var spl = log.Split(':');
            var id = int.Parse(spl[0]);
            var isStart = spl[1][0] == 's';
            var timestamp = int.Parse(spl[2]);

            if (isStart)
            {
                var lastId = stack.Peek();
                stack.Push(id);
                result[lastId] += timestamp - lastTimestamp;
            }
            else
            {
                stack.Pop();
                timestamp++;
                result[id] += timestamp - lastTimestamp;
            }

            lastTimestamp = timestamp;
        }

        return result;
    }
}
