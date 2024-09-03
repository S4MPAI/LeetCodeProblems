using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution45
    {
        public int Jump(int[] nums)
        {
            var jumpsCount = new int[nums.Length];
            for (int i = 0; i < jumpsCount.Length; i++)
                jumpsCount[i] = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;

                var min = Math.Min(nums[i] + i, nums.Length - 1);

                for (int j = i + 1; j <= min; j++)
                    jumpsCount[j] = Math.Min(jumpsCount[i] + 1, jumpsCount[i]);
            }

            return jumpsCount[^1];
        }

        //public int Jump(int[] nums)
        //{

        //    int ans = 0, currEnd = 0, currFar = 0;

        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        currFar = Math.Max(currFar, i + nums[i]);

        //        if (i == currEnd)
        //        {
        //            ans++;
        //            currEnd = currFar;
        //        }
        //    }

        //    return ans;
        //}
    }
}
