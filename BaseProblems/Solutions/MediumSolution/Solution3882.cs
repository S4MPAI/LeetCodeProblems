using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution3882 : BaseTestClass
{
    public int MinCost(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var dp = new bool[n][];
        for (var i = 0; i < n; i++)
            dp[i] = new bool[1024];
        dp[0][grid[0][0]] = true;
        var next = new bool[1024];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == 0 && j == 0)
                    continue;

                var value = grid[i][j];
                Array.Clear(next);

                for (var k = 0; k < 1024; k++)
                    if (dp[j][k] || (j > 0 && dp[j - 1][k]))
                        next[value ^ k] = true;

                Array.Copy(next, dp[j], 1024);
            }
        }

        return Array.IndexOf(dp[n - 1], true);
    }

    public override void Start()
    {
        var grid = new List<int[]>();
        var line = "";
        while ((line = Console.ReadLine()) != string.Empty)
            grid.Add(line.Split(' ').Select(int.Parse).ToArray());

        var b = MinCost(grid.ToArray());
        Console.WriteLine(b);
    }
}
