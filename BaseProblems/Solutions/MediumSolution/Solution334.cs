using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var i = int.MaxValue;
            var j = int.MaxValue;

            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] <= i)
                    i = nums[x];
                else if (nums[x] <= j)
                    j = nums[x];
                else
                    return true;
            }

            return false;
        }
    }
}
