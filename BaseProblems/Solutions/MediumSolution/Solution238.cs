using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var ans = new int[nums.Length];
            var product = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = product;
                product *= nums[i];
            }

            product = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                ans[i] *= product;
                product *= nums[i];
            }

            return ans;
        }
    }
}
