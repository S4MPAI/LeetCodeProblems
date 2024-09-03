using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            var count = 1;
            var currentValue = nums[0];
            var pointer = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    currentValue = nums[i - 1];
                }
                else
                {
                    continue;
                }

                while (pointer < nums.Length && nums[pointer] <= currentValue)
                {
                    pointer++;
                }

                if (pointer >= nums.Length)
                {
                    break;
                }

                count++;
                (nums[i], nums[pointer]) = (nums[pointer], nums[i]);
            }

            return count;
        }
    }
}
