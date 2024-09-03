using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            var start = 0;
            var end = 0;
            var zeroes = 0;

            while (end < nums.Length)
            {
                if (nums[end] == 0)
                    zeroes++;
                end++;

                if (zeroes > k)
                {
                    if (nums[start] == 0)
                        zeroes--;
                    start++;
                }
            }

            return end - start;
        }
    }
}
