using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.EasySolution
{
    public class Solution643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var sum = 0;

            for (int i = 0; i < k; i++) 
                sum += nums[i];
            var max = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                max = Math.Max(max, sum);
            }

            return (double)max / k;
        }
    }
}
