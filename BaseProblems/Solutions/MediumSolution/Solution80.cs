using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution80
    {
        public int RemoveDuplicates(int[] nums)
        {
            var pointer = 0;
            var currentNumber = -1;
            var count = 1;
            var isFirstDuplicate = true;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1] || (nums[i] == nums[i-1] && !isFirstDuplicate))
                    currentNumber = nums[i - 1];
                else
                {
                    isFirstDuplicate = true;
                    if (nums[i] == nums[i - 1])
                        isFirstDuplicate = false;
                    count++;
                    continue;
                }

                while (pointer < nums.Length && nums[pointer] <= currentNumber && !(isFirstDuplicate && nums[pointer] == currentNumber)) 
                    pointer++;

                if (pointer >= nums.Length)
                    break;

                if (nums[pointer] == currentNumber)
                    isFirstDuplicate = false;
                else
                    isFirstDuplicate = true;

                (nums[i], nums[pointer]) = (nums[pointer], nums[i]);
                count++;
            }

            return count;
        }
    }
}
