using BaseProblems.HelperClasses;

namespace BaseProblems.Solutions.MediumSolution;

public class Solution2333 : BaseTestClass
{
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
    {
        var k = k1 + k2;
        var differences = nums1
            .Zip(nums2, (a, b) => Math.Abs(a - b))
            .OrderByDescending(x => x)
            .ToArray();

        var min = 0;
        var max = differences[0];
        var bestHeight = 0;
        while (min <= max)
        {
            var mid = (min + max) / 2;
            var modifiers = k;

            foreach (var diff in differences)
            {
                if (mid >= diff || modifiers < 0)
                    break;

                modifiers -= diff - mid;
            }

            if (modifiers >= 0)
            {
                bestHeight = mid;
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        var i = 0;
        while (k > 0 && i < differences.Length && differences[i] > bestHeight)
        {
            k -= differences[i] - bestHeight;
            differences[i++] = bestHeight;
        }
        i = 0;
        while (k-- > 0 && differences[i] > 0)
            differences[i++]--;

        var result = differences.Select(x => (long)x * x).Sum();
        return result;
    }

    public long MinSumSquareDiffV2(int[] nums1, int[] nums2, int k1, int k2)
    {
        long k = k1 + k2;
        var n = nums1.Length;
        var sum = 0L;
        for (var i = 0; i < n; i++)
        {
            nums1[i] = Math.Abs(nums1[i] - nums2[i]);
            sum += nums1[i];
        }

        if (sum <= k)
            return 0;

        Array.Sort(nums1);
        Array.Reverse(nums1);
        Array.Resize(ref nums1, n + 1);

        for (var i = 1; i <= n; i++)
        {
            var cost = (long)(nums1[i - 1] - nums1[i]) * i;
            if (cost > k)
            {
                var hi = nums1[i - 1] - k / i;
                var r = k % i;
                var answer = hi * hi * (i - r) + (hi - 1) * (hi - 1) * r;

                for (var j = i; j < n; j++)
                    answer += (long)nums1[j] * nums1[j];

                return answer;
            }

            k -= cost;
        }

        return 0;
    }

    public override void Start()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var k1 = int.Parse(Console.ReadLine());
        var k2 = int.Parse(Console.ReadLine());

        var c = MinSumSquareDiff(a, b, k1, k2);
        Console.WriteLine(c);
    }
}
