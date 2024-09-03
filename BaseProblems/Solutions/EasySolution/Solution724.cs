using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution724
    {
        public int PivotIndex(int[] nums)
        {
            var leftSum = 0;
            var rightSum = nums.Sum() - nums[0];

            for (var i = 0; i < nums.Length; i++)
            {
                if (leftSum == rightSum)
                    return i;
                leftSum += nums[i];
                rightSum -= i + 1 < nums.Length ? nums[i + 1] : 0;
            }

            return -1;
        }

        public int PivotIndex1(int[] nums)
        {
            int leftsum = 0;
            int sum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftsum == sum - leftsum - nums[i])
                    return i;

                leftsum += nums[i];
            }
            return -1;
        }
    }
}
