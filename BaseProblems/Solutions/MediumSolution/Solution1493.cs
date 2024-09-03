using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1493
    {
        public int LongestSubarray(int[] nums)
        {
            var last = 0;
            var current = 0;
            var max = 0;
            var elementIsDeleted = false;

            for (var i = 0; i < nums.Length + 1; i++)
            {
                if (i == nums.Length || nums[i] == 0)
                {
                    if (i != nums.Length && nums[i] == 0) elementIsDeleted = true;

                    max = Math.Max(max, current + last);
                    last = current;
                    current = 0;
                }
                else
                    current++;
            }

            return max - (elementIsDeleted ? 0 : 1);
        }
    }
}
