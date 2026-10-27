namespace BaseProblems.Solutions.EasySolution;

public class Solution3963
{
    public string[] CreateGrid(int m, int n)
    {
        var startPath = new string('.', n);
        var nextPaths = new string('#', n - 1) + '.';
        var result = new string[m];
        result[0] = startPath;

        for (var i = 1; i < m; i++)
            result[i] = nextPaths;

        return result;
    }
}
