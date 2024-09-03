using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution896
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length <= 1) 
                return true;

            var isIncreasing = nums[0] <= nums[^1];

            for ( var i = 0; i < nums.Length - 1; i++)
            {
                if (!(isIncreasing && nums[i] <= nums[i + 1]) && !(!isIncreasing && nums[i] >= nums[i + 1]))
                    return false;
            }

            return true;
        }
    }
}
