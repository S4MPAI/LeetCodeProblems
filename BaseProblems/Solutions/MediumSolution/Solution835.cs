using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution835 : BaseTestClass
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        var n = img1.Length;
        var imgA = new List<(int y, int x)>();
        var imgB = new List<(int y, int x)>();

        for (var y = 0; y < n; y++)
        for (var x = 0; x < n; x++)
        {
            if (img1[y][x] == 1)
                imgA.Add((y, x));
            if (img2[y][x] == 1)
                imgB.Add((y, x));
        }

        var translateToOverlap = new Dictionary<(int y, int x), int>();
        foreach (var itemA in imgA)
        foreach (var itemB in imgB)
        {
            var translate = (itemB.y - itemA.y, itemB.x - itemA.x);
            translateToOverlap.TryAdd(translate, 0);
            translateToOverlap[translate]++;
        }

        if (translateToOverlap.Count == 0)
            return 0;

        return translateToOverlap.Max(x => x.Value);
    }

    public override void Start()
    {
        var nums1 = ReadMatrix();
        var nums2 = ReadMatrix();
        Console.WriteLine(LargestOverlap(nums1, nums2));
    }

    private int[][] ReadMatrix()
    {
        string line;
        var nums = new List<int[]>();

        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            nums.Add(line.Split().Select(int.Parse).ToArray());

        return nums.ToArray();
    }
}
