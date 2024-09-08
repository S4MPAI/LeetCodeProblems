using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var startIndex = 0;
            var sum = 0;
            var result = int.MaxValue;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
                while (sum - nums[startIndex] >= target)
                {
                    sum -= nums[startIndex];
                    startIndex++;
                }
                if (sum >= target)
                {
                    result = Math.Min(result, i - startIndex + 1);
                }
            }

            return result == int.MaxValue ? 0 : result;
        }
    }
}
