using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3970 : BaseTestClass
{
    public int ShortestPath(int n, int[][] edges, string labels, int k)
    {
        var priorityNodes = new PriorityQueue<(int node, int weight, int count), int>();
        var startNodeToEndNode = new List<(int endNode, int weight)>[n];
        for (var i = 0; i < n; i++)
            startNodeToEndNode[i] = [];

        foreach (var edge in edges)
            startNodeToEndNode[edge[0]].Add((edge[1], edge[2]));

        var visited = new int[n, k];
        for (var i = 0; i < n; i++)
        for (var j = 0; j < k; j++)
            visited[i, j] = int.MaxValue;

        priorityNodes.Enqueue((0, 0, 0), 0);
        while (priorityNodes.Count > 0)
        {
            var (node, weight, count) = priorityNodes.Dequeue();

            if (weight > visited[node, count])
                continue;

            if (node == n - 1)
                return weight;

            var nearNodes = startNodeToEndNode[node];
            foreach (var (nearNode, nearNodeWeight) in nearNodes)
            {
                var repeatCount = labels[nearNode] == labels[node] ? count + 1 : 0;
                if (repeatCount >= k)
                    continue;

                var nextWeight = weight + nearNodeWeight;

                if (nextWeight < visited[nearNode, repeatCount])
                {
                    priorityNodes.Enqueue((nearNode, nextWeight, repeatCount), nextWeight);
                    visited[nearNode, repeatCount] = nextWeight;
                }
            }
        }

        return -1;
    }

    public override void Start()
    {
        var n = int.Parse(Console.ReadLine());
        var edges = new List<int[]>();
        var line = "";
        while ((line = Console.ReadLine()) != "")
            edges.Add(line.Split().Select(x => int.Parse(x)).ToArray());
        var labels = Console.ReadLine();
        var k = int.Parse(Console.ReadLine());

        var result = ShortestPath(n, edges.ToArray(), labels, k);
        Console.WriteLine(result);
    }
}
