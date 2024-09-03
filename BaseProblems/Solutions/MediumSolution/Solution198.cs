using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution198
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            var bestRobbing = new int[nums.Length];
            bestRobbing[0] = nums[0];
            bestRobbing[1] = nums[1] > nums[0] ? nums[1] : nums[0];

            for (int i = 2; i < bestRobbing.Length; i++)
            {
                bestRobbing[i] = Math.Max(bestRobbing[i - 1], bestRobbing[i - 2] + nums[i]);
            }

            return bestRobbing[^1];
        }
    }
}
