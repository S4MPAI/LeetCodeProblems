using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution189
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            var n = nums.Length;
            ReverseNum(nums, 0, n - 1);
            ReverseNum(nums, 0, k - 1);
            ReverseNum(nums, k, n - 1);
        }

        private void ReverseNum(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[start], nums[end]) = (nums[end], nums[start]);
                start++;
                end--;
            }
        }
    }
}
