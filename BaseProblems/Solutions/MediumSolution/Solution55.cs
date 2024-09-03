using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution55
    {
        public bool CanJump(int[] nums)
        {
            var max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (max < i)
                    return false;

                max = Math.Max(max, nums[i] + i);
            }

            return true;
        }
    }
}
